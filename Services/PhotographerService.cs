using LensFolio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LensFolio.Services
{
    public class PhotographerService
    {
        private readonly List<Photographer> _photographers = new List<Photographer>();

        public PhotographerService()
        {
            // Seed with example data
            _photographers.Add(new Photographer
            {
                PhotographerId = 1,
                Name = "Jacky",
                Email = "jackye@example.com",
                Bio = "Professional photographer with 10 years of experience.",
                ProfilePictureUrl = "https://www.google.com/imgres?q=labrador&imgurl=https%3A%2F%2Fwww.vidavetcare.com%2Fwp-content%2Fuploads%2Fsites%2F234%2F2022%2F04%2Flabrador-retriever-dog-breed-info.jpeg&imgrefurl=https%3A%2F%2Fwww.vidavetcare.com%2Fdog-breed%2Flabrador-retriever%2F&docid=cspgENaYjkhLCM&tbnid=nqvK8MNbbOD64M&vet=12ahUKEwjAiMz61fSHAxXRmYkEHU8BMOAQM3oECBoQAA..i&w=500&h=500&hcb=2&ved=2ahUKEwjAiMz61fSHAxXRmYkEHU8BMOAQM3oECBoQAA",
                Portfolios = new List<Portfolio>
                {
                    new Portfolio { PortfolioId = 1, Title = "Nature Photography", Description = "A collection of nature shots." }
                }
            });
        }

        public Task<List<Photographer>> GetPhotographersAsync()
        {
            return Task.FromResult(_photographers);
        }

        public Task<Photographer> GetPhotographerByIdAsync(int id)
        {
            var photographer = _photographers.FirstOrDefault(p => p.PhotographerId == id);
            return Task.FromResult(photographer);
        }

        public Task AddPhotographerAsync(Photographer photographer)
        {
            _photographers.Add(photographer);
            return Task.CompletedTask;
        }

        public Task UpdatePhotographerAsync(Photographer photographer)
        {
            var existingPhotographer = _photographers.FirstOrDefault(p => p.PhotographerId == photographer.PhotographerId);
            if (existingPhotographer != null)
            {
                existingPhotographer.Name = photographer.Name;
                existingPhotographer.Email = photographer.Email;
                existingPhotographer.Bio = photographer.Bio;
                existingPhotographer.ProfilePictureUrl = photographer.ProfilePictureUrl;
            }
            return Task.CompletedTask;
        }

        public Task DeletePhotographerAsync(int id)
        {
            var photographer = _photographers.FirstOrDefault(p => p.PhotographerId == id);
            if (photographer != null)
            {
                _photographers.Remove(photographer);
            }
            return Task.CompletedTask;
        }
        
    }
}
