using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using RepositoryPatternEntity.Repositories.Abstractions;

namespace RepositoryPatternEntity.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IRepositoryBase<Usuario> _repository;

        public UsuarioRepository(IRepositoryBase<Usuario> repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(Usuario usuario)
        {
            await _repository.AddAsync(usuario);
        }

        public async Task GetById(Usuario usuario)
        {
            await _repository.GetAsync(it => it.Id == usuario.Id);
        }
    }
}
