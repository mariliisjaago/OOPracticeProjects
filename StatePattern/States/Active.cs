using System;

namespace StatePattern.States
{
    public class Active : IPetState
    {
        private readonly Action _cheerOnAdoption;

        public Active(Action cheerOnAdoption)
        {
            _cheerOnAdoption = cheerOnAdoption;
        }

        public IPetState Adopt()
        {
            _cheerOnAdoption();
            return new Adopted();
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
            return new Sick(_cheerOnAdoption);
        }

        public IPetState VaccinationVerified()
        {
            return this;
        }
    }
}
