using System;

namespace StatePattern.States
{
    public class Adopted : IPetState
    {
        public IPetState Adopt()
        {
            return this;
        }
        public IPetState PostNewPhotos(Action addPhotos)
        {
            return this;
        }
        public IPetState RemoveOldPhotos(Action removePhotos)
        {
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
