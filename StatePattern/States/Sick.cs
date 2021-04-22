using System;

namespace StatePattern.States
{
    public class Sick : IPetState
    {
        private readonly Action _cheerOnAdoption;

        public Sick(Action cheerOnAdoption)
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
            return new Active(_cheerOnAdoption);
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
            return this;
        }
    }
}
