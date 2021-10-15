using FurnitureWebStore.Models.DTOs.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureWebStore.Models.Interfaces
{
    public interface IFeedbackServices
    {

        FeedbackVM GetFeedback(int id);
        void AddFeedback(FeedbackVM dto);
        void UpdateFeedback(int id, FeedbackVM dto);
        void DeleteFeedback(int id);
    }
}
