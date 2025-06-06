using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProductManagement.BLL;
using ProductManagement.DAL;

[TestClass]
public class ProductServiceTests
{
    [TestMethod]
    public void TaxMustReturn19percent()
    {
        // Arrange
        var mockApiClient = new Mock<IProductApiClient>();
        var service = new ProductService(mockApiClient.Object);

        decimal precio = 100m;
        decimal esperado = 19m;

        // Act
        decimal impuesto = service.CalcularImpuesto(precio);

        // Assert
        Assert.AreEqual(esperado, impuesto);
    }
}
