using BenchmarkDotNet.Attributes;
using BenchMarkPerformanceAnalysis.Data;
using BenchMarkPerformanceAnalysis.Models;
using BenchMarkPerformanceAnalysis.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchMarkPerformanceAnalysis.Benchmarks
{
    [MemoryDiagnoser] // This attribute allows to measure memory usage
    public class ProductBenchmarks
    {
        private readonly ProductRepository _productRepository;

        public ProductBenchmarks()
        {
            var context = new AppDbContext();
            context.Database.EnsureCreated(); // Ensure database is created
            _productRepository = new ProductRepository(context);
        }

        [Benchmark]
        public void CreateProductBenchmark()
        {
            var newProduct = new Product { Name = "Benchmark Product", Price = 19.99M };
            _productRepository.AddProduct(newProduct);
        }

        [Benchmark]
        public List<Product> ReadProductsBenchmark()
        {
            return _productRepository.GetAllProducts();
        }

        [Benchmark]
        public void UpdateProductBenchmark()
        {
            //var product = new Product { Id = 1, Name = "Updated Product", Price = 29.99M };
            //_productRepository.UpdateProduct(product);

            var product = _productRepository.GetProductById(1);
            if (product != null)
            {
                product.Name = "Updated Product";
                product.Price = 29.99M;
                _productRepository.UpdateProduct(product);
            }
        }

        [Benchmark]
        public void DeleteProductBenchmark()
        {
            //_productRepository.DeleteProduct(1);

            var product = _productRepository.GetProductById(1);
            if (product != null)
            {
                _productRepository.DeleteProduct(1);
            }
        }
    }
}
