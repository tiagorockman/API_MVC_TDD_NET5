using Microsoft.EntityFrameworkCore;
using Models;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CursoMVCAPITest
{
    public class CategoriaControllerTest
    {
        //Realizando Mock do Context
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;

        public CategoriaControllerTest()
        {
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContext = new Mock<Context>();
            _categoria = new Categoria { Id = 1, Descricao = "Teste Mock" };

            _mockContext.Setup(m => m.Categorias).Returns(_mockSet.Object); // Categorias do mockContext se refere ao mokSet
            _mockContext.Setup(m => m.Categorias.FindAsync(1)).ReturnsAsync(_categoria); // Ensina para o mock o FindAsync de Categorias

            _mockContext.Setup(m => m.SetModifield(_categoria));
            _mockContext.Setup(m => m.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(1);
        }

        [Fact]
        public async Task Get_Categoria()
        {
            var service = new CursoAPI.Controllers.CategoriasController(_mockContext.Object);

            await service.GetCategoria(1);

            _mockSet.Verify(m => m.FindAsync(1), Times.Once()); // Verifica se executou o FindAsyn pelo menos 1 vez
        }

        [Fact]
        public async Task Put_Categoria()
        {
            var service = new CursoAPI.Controllers.CategoriasController(_mockContext.Object);
            await service.PutCategoria(1, _categoria);

            _mockContext.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once());
        }

        [Fact]
        public async Task Post_Categoria()
        {
            var service = new CursoAPI.Controllers.CategoriasController(_mockContext.Object);
            await service.PostCategoria(_categoria);

            _mockSet.Verify(mocks => mocks.Add(_categoria), Times.Once);
            _mockContext.Verify(mocks => mocks.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once());
        }
        [Fact]
        public async Task Delete_Categoria()
        {
            var service = new CursoAPI.Controllers.CategoriasController(_mockContext.Object);
            await service.DeleteCategoria(1);

            _mockSet.Verify(mocks => mocks.FindAsync(1), Times.Once);
            _mockSet.Verify(mocks => mocks.Remove(_categoria), Times.Once);
            _mockContext.Verify(mocks => mocks.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
