using NUnit.Framework;

namespace ElektroFramework.ShoppingCart.Tests
{
    [TestFixture]
    public class ShoppingCartTests
    {
        private CartItem _cartItem;
        private CartManager _cartManager;
        
        [SetUp]
        public void TestInitialize()
        {
            _cartManager = new CartManager();
            _cartItem=new CartItem
            {
                Product = new Product()
                {
                    ProductId = 1,
                    ProductName = "Notebook",
                    UnitPrice = 2500
                },
                Quantity = 1
            };
            _cartManager.Add(_cartItem);
        }

        [TearDown]
        public void TestCleanUp()
        {
            _cartManager.Clear();
        }
        
        [Test]
        public void should_be_add_products_to_cart()
        {
            const int expected = 1;
            var itemsSum = _cartManager.TotalItems;
            Assert.AreEqual(expected,itemsSum);
        }

        [Test]
        public void should_be_able_to_remove_product_to_cart()
        {
            var itemsSum = _cartManager.TotalItems;
            
            //Act
            _cartManager.Remove(1);
            var itemsRemaing = _cartManager.TotalItems;
            
            //Assert
            Assert.AreEqual(itemsSum-1,itemsRemaing);
        }

        [Test]
        public void should_be_able_to_clear_to_cart()
        {
            //Act
            _cartManager.Clear();
            
            //Assert
            Assert.AreEqual(0,_cartManager.TotalItems);
            Assert.AreEqual(0,_cartManager.TotalPrice);

        }
        
    }
}