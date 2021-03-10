using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Manager.Domain.Entities;
using Manager.Infra.Interfaces;
using Manager.Services.DTO;
using Manager.Core.Exceptions;
using Manager.Services.Interfaces;

namespace Manager.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<UserDTO> Create(UserDTO userDTO)
        {
            var userExists = await _userRepository.GetByEmail(userDTO.Email);

            if (userExists != null)
                throw new DomainException("Já existe um usuário cadastro com o email informado.");

            var user = _mapper.Map<User>(userDTO);
            user.Validate();

            var userCreated = await _userRepository.Create(user);

            return _mapper.Map<UserDTO>(userCreated);
        }


        public async Task<UserDTO> Update(UserDTO userDTO)
        {
            var userExists = await _userRepository.GetByEmail(userDTO.Email);

            if (userExists != null)
                throw new DomainException("Já existe um usuário cadastro com o email informado.");

            var user = _mapper.Map<User>(userDTO);
            user.Validate();

            var userCreated = await _userRepository.Update(user);

            return _mapper.Map<UserDTO>(userCreated);
        }

        public async Task<List<UserDTO>> Get()
        {
            var allUsers = await _userRepository.Get();

            return _mapper.Map<List<UserDTO>>(allUsers);
        }

        public async Task<UserDTO> Get(long id)
        {
            var user = await _userRepository.Get(id);

            return _mapper.Map<UserDTO>(user);
        }

        public async Task Remove(long id)
        {

            var userExists = await _userRepository.Get(id);

            if (userExists != null)
                await _userRepository.Remove(id);
            else
                throw new DomainException("ID não Encontrado");
        }
        public async Task<List<UserDTO>> SearchByNome(string nome)
        {
            var allUsers = await _userRepository.SearchByNome(nome);

            return _mapper.Map<List<UserDTO>>(allUsers);
        }

        public async Task<UserDTO> GetByEmail(string email)
        {
            var user = await _userRepository.GetByEmail(email);

            return _mapper.Map<UserDTO>(user);
        }

        public async Task<List<UserDTO>> SearchByEmail(string email)
        {
            var allUsers = await _userRepository.SearchByEmail(email);

            return _mapper.Map<List<UserDTO>>(allUsers);
        }


    }


}