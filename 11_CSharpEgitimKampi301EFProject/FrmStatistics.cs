using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            #region Toplam Lokasyon Sayısı
            lblLocationCount.Text = db.Location.Count().ToString();
            #endregion

            #region Toplam Kapasite
            lblSumCapacity.Text = db.Location.Sum(x=> x.Capacity).ToString();
            #endregion

            #region Rehber Sayısı
            lblGuideCount.Text = db.Guide.Count().ToString();
            #endregion

            #region Ortalama Kapasite
            lblAvgCapacity.Text = db.Location.Average(x=> x.Capacity).ToString();
            #endregion

            #region Ortalama Tur Fiyatı
            lblAvgTour.Text = db.Location.Average(x=> x.Price).ToString().TrimEnd('0').TrimEnd(',')+" ₺";
            #endregion

            #region Eklenen Son Ülke
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountry.Text = db.Location.Where(x=> x.LocationId == lastCountryId).Select(y=> y.Country).FirstOrDefault();
            #endregion

            #region Kapadokya Tur Kapasitesi
            // tek bir kayıt istediğimiz için firstordefault metodunu çalıştırıyoruz
            lblCapadociaLocationCapacity.Text = db.Location.Where(x=> x.City == "Kapadokya").Select(y=> y.Capacity).FirstOrDefault().ToString();
            #endregion

            #region Türkiyedeki turların ortalama kapasitesi
            lblTurOrtCapacity.Text = db.Location.Where(x=> x.Country == "Türkiye").Average(y=> y.Capacity).ToString();
            #endregion

            #region Roma Gezisinin Rehberinin Adı
            var guideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            lblRomaGuideName.Text = db.Guide.Where(x => x.GuideId == guideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
            #endregion

            #region En Yüksek Kapasiteli Tur
            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityTour.Text = db.Location.Where(x=> x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();
            #endregion

            #region En Pahalı Tur
            var veryExpensiveTour = db.Location.Max(x => x.Price);
            lblVeryExpensiveTour.Text = db.Location.Where(x=>x.Price == veryExpensiveTour).Select(y=>y.City).FirstOrDefault().ToString();
            #endregion

            #region Ali Yıldız ın tur sayısı
            var personId = db.Guide.Where(x=>x.GuideName == "Ali" && x.GuideSurname == "Yıldız").Select(y=>y.GuideId).FirstOrDefault();
            lblAliTourCount.Text = db.Location.Where(x=>x.GuideId == personId).Count().ToString();
            #endregion

        }


    }
}
