using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public string SobreNome { get; set; }

        public ICollection<ClientePhoneViewModel> Phones { get; set; }
        public FuncionarioIsClienteView Funcionario { get; set; }
        public DateTime DataNascimeto { get; set; }
        public int EnderecoId { get; set; }

        public bool IsFuncionario { get; set; } = false;

        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;

        public UsuarioViewModel(int Id, string name, string sobrenome, string email, ICollection<PhoneViewModel> phones)
        {
            this.Id = Id;
            this.Name = name;
            this.Email = email;
            this.Phones = new List<ClientePhoneViewModel>();
            if (phones.Any())
            {
                foreach (var phone in phones)
                {
                    this.Phones.Add(new ClientePhoneViewModel(Id, phone.Id));
                }
               
            }
            this.Update = DateTime.Now;
            

        }
        public UsuarioViewModel(){}
        public UsuarioViewModel(int Id, string name, string sobrenome, string email, ICollection<PhoneViewModel> phones, bool isFuncionario, ICollection<UsuarioRoleViemModel> roles, ImagesUsuarioViewModel image  )       {
            
            this.Id = Id;
            this.Name = name;
            this.SobreNome = sobrenome;
            this.Email = email;
            this.Phones = new List<ClientePhoneViewModel>();
            if (phones.Any())
            {
                foreach (var phone in phones)
                {
                    this.Phones.Add(new ClientePhoneViewModel(Id, phone.Id));
                }

            }
            this.Update = DateTime.Now;
            this.Funcionario = new FuncionarioIsClienteView(1,Id, roles, image.ImageId);
        }


        public ICollection<UsuarioViewModel> list()
        {
            var cliente1Phones = new List<ClientePhoneViewModel>();
          
            var phones = new List<PhoneViewModel>();
            var images = new List<ImageViewModel>();

            var clientes = new List<UsuarioViewModel>();
            #region Cadastro cliente 01
            var cliente1 = new UsuarioViewModel();

            cliente1.Id = 1;
            cliente1.Name = "edvanderson";
            cliente1.SobreNome = "Barbosa Lisboa";
            cliente1.Email = "edvandersonlisboa@hotmail.com";

            cliente1.DataNascimeto = DataNascimeto;

            phones.Add(new PhoneViewModel(1, "974007461", "68", "55"));
            phones.Add(new PhoneViewModel(2, "974007467", "68", "55"));
            cliente1Phones.Add(new ClientePhoneViewModel(cliente1.Id, 1));
            cliente1Phones.Add(new ClientePhoneViewModel(cliente1.Id, 2));
            cliente1.Phones = cliente1Phones;
            var cliente1Endereco = new EnderecoViewModel();
            cliente1Endereco.Id = 1;
            cliente1Endereco.Update = DateTime.Now;
            cliente1Endereco.Estado = "SP";
            cliente1Endereco.Rua = "alamedas do almado";

            cliente1.EnderecoId = cliente1Endereco.Id;
            cliente1.IsFuncionario = true;

            if (cliente1.IsFuncionario)
            {
                var roles = new  List<UsuarioRoleViemModel>();
                roles.Add(new UsuarioRoleViemModel(1, "Administrador"));
                
                var image = new ImagesUsuarioViewModel(1,cliente1.Id);

                cliente1.Funcionario = new FuncionarioIsClienteView(1, cliente1.Id,roles, image.ImageId);
            }

            cliente1.Update = DateTime.Now;

            #endregion fim do cadastro

            #region Cadastro Cliente 2
            var cliente2 = new UsuarioViewModel();
            var cliente2Phones = new List<ClientePhoneViewModel>();


            cliente2.Id = 2;
            cliente2.Name = "Maria";
            cliente2.SobreNome = "Da Silva Lisboa";
            cliente2.Email = "edvandersonlisboa@hotmail.com";

            cliente1.DataNascimeto = DataNascimeto;

            phones.Add(new PhoneViewModel(1, "974007072", "81", "55"));
            phones.Add(new PhoneViewModel(2, "9740074645", "91", "55"));
            cliente2Phones.Add(new ClientePhoneViewModel(cliente2.Id, 3));
            cliente2Phones.Add(new ClientePhoneViewModel(cliente2.Id, 4));
            var cliente2Endereco = new EnderecoViewModel();
            cliente2Endereco.Id = 2;
            cliente2Endereco.Update = DateTime.Now;
            cliente2Endereco.Estado = "SP";
            cliente2Endereco.Cidade = "mogi das cruzes";
            cliente2Endereco.Rua = "alamedas contra file";

            cliente2.EnderecoId = cliente2Endereco.Id;

            cliente2.Update = DateTime.Now;

            #endregion fim do cadastro

            clientes.Add(cliente1);
            clientes.Add(cliente2);
            return clientes;
        }
    }
}
