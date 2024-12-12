using HandMadeCakes.Data;
using HandMadeCakes.Dto;
using HandMadeCakes.Models;
using Microsoft.EntityFrameworkCore;

namespace HandMadeCakes.Services.Cake
{
    public class CakeService : ICakeInterface
    {
        private readonly AppDbContext _context;

        private readonly string _sistema;

        public CakeService(AppDbContext context, IWebHostEnvironment sistema)
        {
            _context = context;
            _sistema = sistema.WebRootPath;
        }


        public string GeraCaminhoArquivo(IFormFile foto)
        {
            var codigoUnico = Guid.NewGuid().ToString();//Gera um a cadeia de caracteres variaveis e assim o nome da imagem sempre sera diferente
            var nomeCaminhoImagem = foto.FileName.Replace(" ", "").ToLower() + codigoUnico + ".png";

            var caminhoParaSalvarImagens = _sistema + "\\imagem\\";


            if (!Directory.Exists(caminhoParaSalvarImagens))
            {
                Directory.CreateDirectory(caminhoParaSalvarImagens);
            }

            using (var stream = File.Create(caminhoParaSalvarImagens + nomeCaminhoImagem))
            {
                foto.CopyToAsync(stream).Wait();
            }

            return nomeCaminhoImagem;


        }

        public async Task<CakeModel> CriarCake(CakeCreateDto CakeCreateDto, IFormFile foto)
        {
            try
            {
                var nomeCaminhoImagem = GeraCaminhoArquivo(foto);

                var Cake = new CakeModel
                {
                    Sabor = CakeCreateDto.Sabor,
                    Descricao = CakeCreateDto.Descricao,
                    Valor = CakeCreateDto.Valor,
                    Capa = nomeCaminhoImagem
                };

                _context.Add(Cake);//salva dentro do BD
                await _context.SaveChangesAsync();

                return Cake;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<CakeModel>> GetCakes()
        {
            try
            {

                return await _context.Cake.ToListAsync(); //vai ao bd e transforma em lista

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CakeModel> GetCakePorId(int id)
        {
            try
            {

                return await _context.Cake.FirstOrDefaultAsync(Cake => Cake.Id == id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CakeModel> EditarCake(CakeModel Cake, IFormFile? foto)
        {
            try
            {
                var CakeBanco = await _context.Cake.AsNoTracking().FirstOrDefaultAsync(CakeBD => CakeBD.Id == Cake.Id);

                var nomeCaminhoImagem = "";

                if (foto != null)
                {
                    string caminhoCapaExistente = _sistema + "\\imagem\\" + CakeBanco.Capa;

                    if (File.Exists(caminhoCapaExistente))
                    {
                        File.Delete(caminhoCapaExistente);
                    }

                    nomeCaminhoImagem = GeraCaminhoArquivo(foto);
                }


                CakeBanco.Sabor = Cake.Sabor;
                CakeBanco.Descricao = Cake.Descricao;
                CakeBanco.Valor = Cake.Valor;

                if (nomeCaminhoImagem != "")
                {
                    CakeBanco.Capa = nomeCaminhoImagem;
                }
                else
                {
                    CakeBanco.Capa = Cake.Capa;
                }

                _context.Update(CakeBanco);
                await _context.SaveChangesAsync();

                return Cake;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CakeModel> RemoverCake(int id)
        {
            try
            {
                var cake = await _context.Cake.FirstOrDefaultAsync(Cakebanco => Cakebanco.Id == id);

                _context.Remove(cake);
                await _context.SaveChangesAsync();

                return cake;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<CakeModel>> GetCakesFiltro(string? pesquisar)
        {
            try
            {

                var Cakes = await _context.Cake.Where(CakeBanco => CakeBanco.Sabor.Contains(pesquisar)).ToListAsync();
                return Cakes;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<CakeModel> CriarPizza(CakeCreateDto CakeCreateDto, IFormFile foto)
        {
            throw new NotImplementedException();
        }

        public Task<List<CakeModel>> GetCake()
        {
            throw new NotImplementedException();
        }

        public Task<CakeModel> GetPizzaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CakeModel> EditarPizza(CakeModel pizza, IFormFile? foto)
        {
            throw new NotImplementedException();
        }

        public Task<CakeModel> RemoverPizza(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CakeModel>> GetCakeFiltro(string? pesquisar)
        {
            throw new NotImplementedException();
        }
    }
}