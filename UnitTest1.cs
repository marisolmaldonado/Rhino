using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using RhinoCommon;

namespace Rhino.Test
{
    [TestClass]
    public class UnitTest1
    {
        private IPedido Pedido;
        private IBodega Bodega;
        const string JugoGuanabana = "Jugo de Guanabana";
        Bodega bodega = new Bodega();
        [TestMethod]
        public void LaOrdenSeLlenaSiHaySuficienteEnLaBodega()
        {
            int existenciaJugoMora = 0;
            IPedido pedidoMock = MockRepository.GenerateStrictMock<IPedido>();
            pedidoMock.Expect(x => x.Llenar(bodega));

            Assert.IsTrue(pedidoMock.SeLleno);
            Assert.AreEqual(existenciaJugoMora, bodega.Existencia(JugoGuanabana));
            pedidoMock.VerifyAllExpectations();
        }
    }
}
