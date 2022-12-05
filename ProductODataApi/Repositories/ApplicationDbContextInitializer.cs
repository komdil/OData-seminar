using ProductAPI.Abstractions;
using ProductAPI.Model;

namespace ProductAPI.Repositories
{
    public class ApplicationDbContextInitializer : IApplicationDbContextInitializer
    {
        ApplicationDbContext _applicationDbContext;
        public ApplicationDbContextInitializer(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Init()
        {
            _applicationDbContext.Database.EnsureDeleted();
            if (_applicationDbContext.Database.EnsureCreated())
            {
                var laptop = new Laptop()
                {
                    Id = Guid.NewGuid(),
                    CPU = "i7",
                    Description = "Acer Laptop Aspire 5 Intel Core i7 12th Gen 1255U (1.70GHz) 16GB Memory 512 GB NVMe SSD Intel Iris Xe Graphics 15.6\" Windows 11 Home 64-bit A515-57-731E",
                    HardDrive = 512,
                    Manufacturer = "Acer",
                    Name = "Acer Laptop Aspire",
                    Price = 769,
                    Ram = 16
                };
                _applicationDbContext.Add(laptop);

                laptop = new Laptop()
                {
                    Id = Guid.NewGuid(),
                    CPU = "Carbon",
                    Description = "Lenovo ThinkPad X1 Carbon Gen 10 Intel Laptop, 14.0\" IPS Touch 60Hz Low Blue Light, vPro®, Iris Xe Graphics, 32GB, 1TB, Win 11 Pro, One YR Onsite Warranty",
                    HardDrive = 1000,
                    Manufacturer = "Lenovo",
                    Name = "Lenovo ThinkPad X1",
                    Price = 2089,
                    Ram = 32
                };
                _applicationDbContext.Add(laptop);

                laptop = new Laptop()
                {
                    Id = Guid.NewGuid(),
                    CPU = "i7",
                    Description = "Lenovo ThinkPad P16 Intel Laptop, 16.0\" IPS Touch 60Hz Low Blue Light, i7-12800HX, NVIDIA RTX A1000 Laptop GPU 4GB GDDR6, 32GB, 1TB, Win 11 Pro, One YR Onsite Warranty",
                    HardDrive = 1000,
                    Manufacturer = "Lenovo",
                    Name = "Lenovo ThinkPad P16 Intel Laptop",
                    Price = 769,
                    Ram = 16
                };
                _applicationDbContext.Add(laptop);

                laptop = new Laptop()
                {
                    Id = Guid.NewGuid(),
                    CPU = "Ryzen",
                    Description = "ASUS ZenBook Pro 15 OLED Laptop 15.6\" FHD Touch Display, AMD Ryzen 7 5800H CPU, NVIDIA GeForce RTX 3050 Ti GPU, 16GB RAM, 1TB PCIe SSD, Windows 11 Pro, Pine Grey, UM535QE-NH71T",
                    HardDrive = 1000,
                    Manufacturer = "ASUS",
                    Name = "ASUS ZenBook Pro",
                    Price = 1199,
                    Ram = 16
                };
                _applicationDbContext.Add(laptop);



                laptop = new Laptop()
                {
                    Id = Guid.NewGuid(),
                    CPU = "i5",
                    Description = "Lenovo ThinkPad X1 Nano Gen 2 Intel Laptop, 13.0\" IPS Touch 60Hz 60Hz, i5-1240P, Iris Xe Graphics, 16GB, 512GB, Win 10 Pro Preinstalled Through Downgrade Rights In Win 11 Pro",
                    HardDrive = 512,
                    Manufacturer = "Lenovo",
                    Name = "Lenovo ThinkPad X1 Nano",
                    Price = 769,
                    Ram = 16
                };
                _applicationDbContext.Add(laptop);

                laptop = new Laptop()
                {
                    Id = Guid.NewGuid(),
                    CPU = "Ryzen",
                    Description = "Acer Laptop Aspire 5 AMD Ryzen 5 5000 Series 5625U (2.30GHz) 8GB Memory 512 GB NVMe SSD AMD Radeon Graphics 15.6\" Windows 11 Home 64-bit A515-47-R3Y6",
                    HardDrive = 512,
                    Manufacturer = "Acer",
                    Name = "Acer Laptop Aspire 5",
                    Price = 599,
                    Ram = 8
                };
                _applicationDbContext.Add(laptop);

                laptop = new Laptop()
                {
                    Id = Guid.NewGuid(),
                    CPU = "Ryzen",
                    Description = "Acer Laptop Aspire 5 AMD Ryzen 7 5000 Series 5825U (2.00GHz) 16GB Memory 512 GB NVMe SSD AMD Radeon Graphics 15.6\" Windows 11 Home 64-bit A515-47-R1XS",
                    HardDrive = 512,
                    Manufacturer = "Acer",
                    Name = "Acer Laptop Aspire 5",
                    Price = 759,
                    Ram = 16
                };
                _applicationDbContext.Add(laptop);

                laptop = new Laptop()
                {
                    Id = Guid.NewGuid(),
                    CPU = "i7",
                    Description = "MSI Laptop Creator M16 Intel Core i7 12th Gen 12700H (2.30GHz) 16GB Memory 512 GB NVMe SSD NVIDIA GeForce RTX 3050 Ti Laptop GPU 16.0\" Windows 11 Pro 64-bit Creator M16 A12UD-266",
                    HardDrive = 512,
                    Manufacturer = "MSI",
                    Name = "MSI Laptop Creator M16",
                    Price = 1199,
                    Ram = 16
                };
                _applicationDbContext.Add(laptop);

                laptop = new Laptop()
                {
                    Id = Guid.NewGuid(),
                    CPU = "i7",
                    Description = "MSI Laptop Creator M16 Intel Core i7 12th Gen 12700H (2.30GHz) 16GB Memory 512 GB NVMe SSD NVIDIA GeForce RTX 3050 Ti Laptop GPU 16.0\" Windows 11 Pro 64-bit Creator M16 A12UD-266",
                    HardDrive = 512,
                    Manufacturer = "MSI",
                    Name = "MSI Laptop Creator M16",
                    Price = 1199,
                    Ram = 16
                };
                _applicationDbContext.Add(laptop);

                laptop = new Laptop()
                {
                    Id = Guid.NewGuid(),
                    CPU = "i7 12th Gen 1255U (1.70GHz)",
                    Description = "Acer Laptop Aspire 5 Intel Core i7 12th Gen 1255U (1.70GHz) 16GB Memory 512 GB NVMe SSD Intel Iris Xe Graphics 15.6\" Windows 11 Home 64-bit A515-57-731E",
                    HardDrive = 512,
                    Manufacturer = "Acer",
                    Name = "Acer Laptop Aspire",
                    Price = 769,
                    Ram = 16
                };
                _applicationDbContext.Add(laptop);

                laptop = new Laptop()
                {
                    Id = Guid.NewGuid(),
                    CPU = "i7 12th Gen 1255U (1.70GHz)",
                    Description = "Acer Laptop Aspire 5 Intel Core i7 12th Gen 1255U (1.70GHz) 16GB Memory 512 GB NVMe SSD Intel Iris Xe Graphics 15.6\" Windows 11 Home 64-bit A515-57-731E",
                    HardDrive = 512,
                    Manufacturer = "Acer",
                    Name = "Acer Laptop Aspire",
                    Price = 769,
                    Ram = 16
                };
                _applicationDbContext.Add(laptop);
                _applicationDbContext.SaveChanges();
            }
        }
    }
}
