using LensFolio.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LensFolio.ViewModels
{
    public class PhotographerProfileViewModel : INotifyPropertyChanged
    {
        private Photographer _photographer;
        public Photographer Photographer
        {
            get => _photographer;
            set
            {
                _photographer = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Portfolio> Portfolios { get; set; }

        public PhotographerProfileViewModel()
        {
            Photographer = new Photographer
            {
                PhotographerId = 1,
                Name = "Jacky",
                Email = "jacky@example.com",
                Bio = "Professional photographer with 10 years of experience.",
                ProfilePictureUrl = "https://www.google.com/imgres?q=labrador&imgurl=https%3A%2F%2Fwww.vidavetcare.com%2Fwp-content%2Fuploads%2Fsites%2F234%2F2022%2F04%2Flabrador-retriever-dog-breed-info.jpeg&imgrefurl=https%3A%2F%2Fwww.vidavetcare.com%2Fdog-breed%2Flabrador-retriever%2F&docid=cspgENaYjkhLCM&tbnid=nqvK8MNbbOD64M&vet=12ahUKEwjAiMz61fSHAxXRmYkEHU8BMOAQM3oECBoQAA..i&w=500&h=500&hcb=2&ved=2ahUKEwjAiMz61fSHAxXRmYkEHU8BMOAQM3oECBoQAA",
                Portfolios = new List<Portfolio>
                {
                    new Portfolio { PortfolioId = 1, Title = "Nature Photography", Description = "A collection of nature shots." }
                }
            };

            Portfolios = new ObservableCollection<Portfolio>(Photographer.Portfolios);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
