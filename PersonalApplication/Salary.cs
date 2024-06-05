using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Organizer_Application
{
    public class Maas
    {
        private double baslangicMaas;
        private double tecrube;
        private double sehir;
        private double egitim;
        private double yabanciDil;
        private double gorevYonetimi;
        private double aileDurumu;
        public double BaslangicMaas { get => baslangicMaas; set => baslangicMaas = value; }
        public double Tecrube { get => tecrube; set => tecrube = value; }
        public double Sehir { get => sehir; set => sehir = value; }
        public double Egitim { get => egitim; set => egitim = value; }
        public double YabanciDil { get => yabanciDil; set => yabanciDil = value; }
        public double GorevYonetimi { get => gorevYonetimi; set => gorevYonetimi = value; }
        public double AileDurmu { get => aileDurumu; set => aileDurumu = value; }
    }
    public abstract class MaasBuilder
    {
        protected Maas _maas = new Maas();
        public Maas Maas
        {
            get { return _maas; }
        }
        public abstract double Hesapla();
    }
    public class KullaniciMaasBuilder : MaasBuilder
    {
        public override double Hesapla()
        {
            return (_maas.BaslangicMaas * (_maas.Tecrube + _maas.Sehir + _maas.AileDurmu + _maas.YabanciDil + _maas.Egitim + _maas.GorevYonetimi + 1));
        }
    }
    public class PartTimeMaasBuilder : MaasBuilder
    {
        public override double Hesapla()
        {
            return ((_maas.BaslangicMaas * (_maas.Tecrube + _maas.Sehir + _maas.AileDurmu + _maas.YabanciDil + _maas.Egitim + _maas.GorevYonetimi + 1) / 2));

        }
    }
    public class MaasHesaplayici
    {
        public double Calculate(MaasBuilder vBuilder)
        {
            return (vBuilder.Hesapla());
        }
    }
}
