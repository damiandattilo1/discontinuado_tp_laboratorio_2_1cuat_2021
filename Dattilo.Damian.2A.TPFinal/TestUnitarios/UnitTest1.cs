using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IgualdadMicroondas_Ok()
        {
            Microondas m1 = new Microondas(5555, EficienciaEnergetica.A, ETamanio.Chico);
            Microondas m2 = new Microondas(7777, EficienciaEnergetica.B, ETamanio.Chico);

            bool res = m1 == m2;

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void IgualdadMicroondas_False()
        {
            Microondas m1 = new Microondas(5555, EficienciaEnergetica.A, ETamanio.Chico);
            Microondas m2 = new Microondas(7777, EficienciaEnergetica.B, ETamanio.Grande);

            bool res = m1 == m2;

            Assert.IsFalse(res);
        }

        [TestMethod]
        public void IgualdadAireAcondicionado_Ok()
        {
            AireAcondicionado ac1 = new AireAcondicionado(5555, EficienciaEnergetica.A, ETipo.Calor);
            AireAcondicionado ac2 = new AireAcondicionado(7777, EficienciaEnergetica.B, ETipo.Calor);

            bool res = (ac1 == ac2);

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void IgualdadAireAcondicionado_False()
        {
            AireAcondicionado ac1 = new AireAcondicionado (5555, EficienciaEnergetica.A, ETipo.Calor);
            AireAcondicionado ac2 = new AireAcondicionado (7777, EficienciaEnergetica.B, ETipo.FrioCalor);

            bool res = (ac1 == ac2);

            Assert.IsFalse(res);
        }


        [TestMethod]
        public void ControlSeguridadAC_Lleno()
        {
            int maximo = 2;
            ControlSeguridad <AireAcondicionado> control = new ControlSeguridad<AireAcondicionado>(maximo);

            AireAcondicionado ac1 = new AireAcondicionado(5555, EficienciaEnergetica.A, ETipo.Calor);
            AireAcondicionado ac2 = new AireAcondicionado(7777, EficienciaEnergetica.B, ETipo.FrioCalor);
            AireAcondicionado ac3 = new AireAcondicionado(5555, EficienciaEnergetica.A, ETipo.Frio);

            Assert.IsTrue(control.Agregar(ac1));
            Assert.IsTrue(control.Agregar(ac2));
            Assert.IsFalse(control.Agregar(ac3));

            Assert.AreEqual(maximo, control.lista.Count);
        }

        [TestMethod]
        public void ControlSeguridadMicroondas_Lleno()
        {
            int maximo = 2;
            ControlSeguridad<Microondas> control = new ControlSeguridad<Microondas>(maximo);

            Microondas m1 = new Microondas(5555, EficienciaEnergetica.A, ETamanio.Chico);
            Microondas m2 = new Microondas(4444, EficienciaEnergetica.A, ETamanio.Grande);
            Microondas m3 = new Microondas(8888, EficienciaEnergetica.D, ETamanio.Mediano);

            Assert.IsTrue(control.Agregar(m1));
            Assert.IsTrue(control.Agregar(m2));
            Assert.IsFalse(control.Agregar(m3));

            Assert.AreEqual(maximo, control.lista.Count);
        }


    }
}
