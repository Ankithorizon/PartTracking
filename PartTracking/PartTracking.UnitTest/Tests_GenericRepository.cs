using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using PartTracking.Context.Models.Models;
using PartTracking.Mvc.Controllers;
using PartTracking.Service.Service;
using PartTracking.Service.UOfW;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PartTracking.UnitTest
{
    public class Tests_GenericRepository
    {
        [Fact]
        public void GenericRepository_AddAndReturn_Returns_PartMaster()
        {
            // Arrange
            var testObject = new PartMaster()
            {
                 PartCode = "part code - 4",
                  PartName = "part name - 4",
                   Quantity = 1000
            };
            var context = new PartMgtContext();
            var partMasterRepository = new GenericRepository<PartMaster>(context);

            // Act
            var justAddedPartMaster = partMasterRepository.AddAndReturn(testObject);

            //Assert            
            Assert.Equal(testObject.PartCode, justAddedPartMaster.PartCode);
        }

        [Fact]
        public void GenericRepository_Add_Returns_Void()
        {
            // Arrange
            var testObject = new PartMaster()
            {
                PartCode = "part code - 5",
                PartName = "part name - 5",
                Quantity = 1000
            };
            var context = new PartMgtContext();
            var partMasterRepository = new GenericRepository<PartMaster>(context);
            var beforeAddCount = context.PartMaster.Count();

            // Act
            partMasterRepository.Add(testObject);
            context.SaveChanges();

            //Assert
            Assert.Equal(context.PartMaster.Count(), beforeAddCount+1);
        }

        [Fact]
        public void GenericRepository_AddRange_Returns_Void()
        {
            // Arrange
            var testObjects = new List<PartMaster>()
            {
                new PartMaster()
                {
                    PartCode = "part code - 6",
                    PartName = "part name - 6",
                    Quantity = 1000
                },
                new PartMaster()
                {
                    PartCode = "part code - 7",
                    PartName = "part name - 7",
                    Quantity = 1000
                }
            };        
            var context = new PartMgtContext();
            var partMasterRepository = new GenericRepository<PartMaster>(context);
            var beforeAddRangeCount = context.PartMaster.Count();

            // Act
            partMasterRepository.AddRange(testObjects);
            context.SaveChanges();

            //Assert
            Assert.Equal(context.PartMaster.Count(), beforeAddRangeCount + testObjects.Count());
        }

        [Fact]
        public void GenericRepository_Find_Returns_IEnumerableOfTypeOfPartMaster()
        {
            // Arrange
            var context = new PartMgtContext();
            var partMasterRepository = new GenericRepository<PartMaster>(context);

            // Act
            List<PartMaster> parts_ = partMasterRepository.Find(x => x.PartMasterId == 1045).ToList();

            //Assert
            Assert.Equal(1, (int)parts_.Count());
        }

        [Fact]
        public void GenericRepository_GetAll_Returns_IEnumerableOfTypeOfPartMaster()
        {
            // Arrange
            var context = new PartMgtContext();
            var partMasterRepository = new GenericRepository<PartMaster>(context);

            // Act
            List<PartMaster> parts_ = partMasterRepository.GetAll().ToList();

            //Assert
            Assert.Equal(context.PartMaster.Count(), (int)parts_.Count());
        }

        [Fact]
        public void GenericRepository_GetById_Returns_TypeOfPartMaster()
        {
            // Arrange
            var context = new PartMgtContext();
            var partMasterRepository = new GenericRepository<PartMaster>(context);
            var id = 1045;

            // Act
            PartMaster part_ = partMasterRepository.GetById(id);

            //Assert
            Assert.Equal(id, part_.PartMasterId);
        }

        // code for controller tests

    }
}
