using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Interfaces
{
    public interface IUserActivateDeactivateApprove
    {
        bool ActivateInstitution(int id);
        bool DeactivateInstitution(int id);

        bool ActivateMentor(int id);
        bool DeactivateMentor(int id);

        bool ActivateStudent(int id);
        bool DeactivateStudent(int id);
        bool CertificateApprove(int id);
    }
}

