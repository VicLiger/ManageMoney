using ManageMoney.Domain.Interfaces;

namespace ManageMoney.Infraestrucutre.Interfaces
{
    internal class BasicImplementionRepository : IBasicImplemention<BasicImplementionRepository>
    {
        public Task<IEnumerable<BasicImplementionRepository>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<BasicImplementionRepository> GetById(Guid Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public void Create(BasicImplementionRepository t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }


        public void Update(BasicImplementionRepository t)
        {
            throw new NotImplementedException();
        }
    }
}
