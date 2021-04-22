using StatePattern.States;
using System;

namespace StatePattern
{
    public class Profile
    {
        public int NumberOfPhotos { get; set; }
        private IPetState _state { get; set; }

        public Profile(Action cheerOnAdoption)
        {
            _state = new VaccinationNotVerified(cheerOnAdoption);
            NumberOfPhotos = 0;
        }

        public void PostNewPhotos(int amount)
        {
            _state = _state.PostNewPhotos(() => { NumberOfPhotos += amount; });
        }
        public void RemoveOldPhotos(int amount)
        {
            _state = _state.RemoveOldPhotos(() => { NumberOfPhotos -= amount; });
        }
        public void SendToDoctor()
        {
            _state = _state.SendToDoctor();
        }
        public void VerifyVaccination()
        {
            _state = _state.VaccinationVerified();
        }
        public void Adopt()
        {
            _state = _state.Adopt();
        }
    }
}
