using System;

namespace StatePattern.States
{
    public class VaccinationNotVerified : IPetState
    {
        private readonly Action _cheerOnAdoption;

        public VaccinationNotVerified(Action cheerOnAdoption)
        {
            _cheerOnAdoption = cheerOnAdoption;
        }

        public IPetState Adopt()
        {
            return this;
        }
        public IPetState PostNewPhotos(Action addPhotos)
        {
            addPhotos();
            return this;
        }
        public IPetState RemoveOldPhotos(Action removePhotos)
        {
            removePhotos();
            return this;
        }
        public IPetState SendToDoctor()
        {
            return this;
        }
        public IPetState VaccinationVerified()
        {
            return new Active(_cheerOnAdoption);
        }
    }
}
