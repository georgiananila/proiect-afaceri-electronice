using AutoMapper;
using FurnitureWebStore.DataAccess.Interfaces;
using FurnitureWebStore.Models.DTOs.VM;
using FurnitureWebStore.Models.Entities;
using FurnitureWebStore.Models.Interfaces;


namespace FurnitureWebStore.Services
{
    public class FeedbackServices : IFeedbackServices
    {
        private readonly IRepository<Feedback, int> feedRep;
        private readonly IMapper mapper;

        public FeedbackServices(IRepository<Feedback, int> feedRep, IMapper mapper)
        {
            this.feedRep = feedRep;
            this.mapper = mapper;
        }

        public void AddFeedback(FeedbackVM dto)
        {
            var entity = mapper.Map<Feedback>(dto);
            feedRep.Add(entity);
        }

        public void DeleteFeedback(int id)
        {
            var entity = feedRep.GetInstance(id);
            if (entity == null)
            {
                return;
            }
            feedRep.Delete(entity);
        }

        public FeedbackVM GetFeedback(int id)
        {
            var entity = feedRep.GetInstance(id);
            return mapper.Map<FeedbackVM>(entity);
        }

        public void UpdateFeedback(int id, FeedbackVM dto)
        {
            var entity = feedRep.GetInstance(id);
            if (entity == null)
            {
                return;
            }
            mapper.Map(dto, entity);
            feedRep.Update(entity);
        }
    }
}
