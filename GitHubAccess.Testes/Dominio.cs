using GitHubAccess.Dominio.Comandos;
using GitHubAccess.Dominio.Entidades;
using GitHubAccess.Dominio.Interfaces;
using GitHubAccess.Dominio.Manipuladores;
using GitHubAccess.Dominio.Resultados;
using Moq;

namespace GitHubAccess.Testes
{
    [TestClass]
    public class Dominio
    {
        private GitHubManipulador _manipulador;

        private Mock<IGitHubRepositorio> MockRepositorio()
        {
            Mock<IGitHubRepositorio> mockRepositorio = new Mock<IGitHubRepositorio>();
            mockRepositorio.Setup(x => x.ObterTodos()).Returns(Task.FromResult(new List<GitHubRepositorio>().AsEnumerable()));
            mockRepositorio.Setup(x => x.AdicionarLista(It.IsAny<List<GitHubRepositorio>>())).Returns(Task.CompletedTask);
            mockRepositorio.Setup(x => x.Commit()).Returns(Task.CompletedTask);

            return mockRepositorio;
        }

        [TestMethod]
        public void Buscar5Repositorios_Ok()
        {
            Mock<IGitHubServico> mockServico = new Mock<IGitHubServico>();
            mockServico.Setup(x => x.BuscarRepositorios())
                       .Returns(Task.FromResult(
                            new List<GitHubRepositorio>() {
                                new GitHubRepositorio(),
                                new GitHubRepositorio(),
                                new GitHubRepositorio(),
                                new GitHubRepositorio(),
                                new GitHubRepositorio()
                            }
                        ));


            _manipulador = new GitHubManipulador(mockServico.Object, MockRepositorio().Object);
            Assert.IsTrue(_manipulador.ManipularAsync(new BuscarRepositoriosComando()).Result.IsValid);
            Assert.AreEqual(((BuscarRepositoriosResultado)_manipulador.ManipularAsync(new BuscarRepositoriosComando()).Result).Repositorios.Count, 5);
        }

        [TestMethod]
        public void BuscarMenosQue5Repositorios_Falhar()
        {
            Mock<IGitHubServico> mockServico = new Mock<IGitHubServico>();
            mockServico.Setup(x => x.BuscarRepositorios())
                       .Returns(Task.FromResult(
                            new List<GitHubRepositorio>() {
                                new GitHubRepositorio(),
                                new GitHubRepositorio(),
                                new GitHubRepositorio(),
                                new GitHubRepositorio()
                            }
                        ));


            _manipulador = new GitHubManipulador(mockServico.Object, MockRepositorio().Object);
            Assert.AreNotEqual(((BuscarRepositoriosResultado)_manipulador.ManipularAsync(new BuscarRepositoriosComando()).Result).Repositorios.Count, 5);
        }

        [TestMethod]
        public void BuscarMaisQue5Repositorios_Falhar()
        {
            Mock<IGitHubServico> mockServico = new Mock<IGitHubServico>();
            mockServico.Setup(x => x.BuscarRepositorios())
                       .Returns(Task.FromResult(
                            new List<GitHubRepositorio>() {
                                new GitHubRepositorio(),
                                new GitHubRepositorio(),
                                new GitHubRepositorio(),
                                new GitHubRepositorio(),
                                new GitHubRepositorio(),
                                new GitHubRepositorio()
                            }
                        ));


            _manipulador = new GitHubManipulador(mockServico.Object, MockRepositorio().Object);
            Assert.AreNotEqual(((BuscarRepositoriosResultado)_manipulador.ManipularAsync(new BuscarRepositoriosComando()).Result).Repositorios.Count, 5);
        }
    }
}