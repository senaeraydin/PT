using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using LibraryViewModelLayer;
using LibraryModelLayer;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace LibraryViewModelLayerTest
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<ICatalogItemRepository> _mockRepository;
        private CatalogItemViewModel _viewModel;

        [TestInitialize]
        public void SetUp()
        {
            // First data generation method
            var catalogItems = new List<CatalogItem>
            {
                new CatalogItem { ItemId = "1", Name = "Item1", Description = "Description1", Price = 10, Quantity = 5 },
                new CatalogItem { ItemId = "2", Name = "Item2", Description = "Description2", Price = 15, Quantity = 10 }
            };

            _mockRepository = new Mock<ICatalogItemRepository>();
            _mockRepository.Setup(repo => repo.GetCatalogItems()).Returns(catalogItems);

            _viewModel = new CatalogItemViewModel(_mockRepository.Object);
        }

        [TestMethod]
        public void CatalogItems_ShouldBePopulated_OnInitialization()
        {
            // Arrange & Act
            var catalogItems = _viewModel.CatalogItems;

            // Assert
            Assert.AreEqual(2, catalogItems.Count);
            Assert.AreEqual("Item1", catalogItems[0].Name);
        }

        [TestMethod]
        public void AddCatalogItemCommand_ShouldAddItem()
        {
            // Arrange
            var newCatalogItem = new CatalogItem { ItemId = "3", Name = "NewItem", Description = "NewCategory", Price = 20, Quantity = 10 };
            _mockRepository.Setup(repo => repo.AddCatalogItem(It.IsAny<CatalogItem>())).Verifiable();

            // Act
            _viewModel.AddCatalogItemCommand.Execute(null);

            // Assert
            Assert.AreEqual(3, _viewModel.CatalogItems.Count);
            _mockRepository.Verify(repo => repo.AddCatalogItem(It.IsAny<CatalogItem>()), Times.Once);
        }

        [TestMethod]
        public void RemoveCatalogItemCommand_ShouldRemoveItem()
        {
            // Arrange
            var itemToRemove = _viewModel.CatalogItems[0];
            _viewModel.SelectedCatalogItem = itemToRemove;
            _mockRepository.Setup(repo => repo.RemoveCatalogItem(itemToRemove.ItemId)).Verifiable();

            // Act
            _viewModel.RemoveCatalogItemCommand.Execute(null);

            // Assert
            Assert.AreEqual(1, _viewModel.CatalogItems.Count);
            _mockRepository.Verify(repo => repo.RemoveCatalogItem(itemToRemove.ItemId), Times.Once);
        }

        [TestMethod]
        public void AddCatalogItemCommand_ShouldAddNewItemUsingSecondMethod()
        {
            // Arrange
            var catalogItems = GenerateCatalogItems();
            _mockRepository.Setup(repo => repo.GetCatalogItems()).Returns(catalogItems);
            _viewModel = new CatalogItemViewModel(_mockRepository.Object);

            var newCatalogItem = new CatalogItem { ItemId = "4", Name = "NewItem", Description = "NewCategory", Price = 20, Quantity = 10 };
            _mockRepository.Setup(repo => repo.AddCatalogItem(It.IsAny<CatalogItem>())).Verifiable();

            // Act
            _viewModel.AddCatalogItemCommand.Execute(null);

            // Assert
            Assert.AreEqual(3, _viewModel.CatalogItems.Count);
            _mockRepository.Verify(repo => repo.AddCatalogItem(It.IsAny<CatalogItem>()), Times.Once);
        }

        private List<CatalogItem> GenerateCatalogItems()
        {
            return new List<CatalogItem>
            {
                new CatalogItem { ItemId = "3", Name = "Item3", Description = "Description3", Price = 20, Quantity = 8 },
                new CatalogItem { ItemId = "4", Name = "Item4", Description = "Description4", Price = 25, Quantity = 12 }
            };
        }
    }
}