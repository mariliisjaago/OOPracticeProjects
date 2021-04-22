using System;

namespace StatePattern
{
    public interface IPetState
    {
        IPetState PostNewPhotos(Action addPhotos);
        IPetState RemoveOldPhotos(Action removePhotos);
        IPetState SendToDoctor();
        IPetState VaccinationVerified();
        IPetState Adopt();
    }
}
