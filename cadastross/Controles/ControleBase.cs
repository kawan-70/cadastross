using Modelos;

namespace Controles
{
    public class ControleBase
     { 
        public virtual void Criar (Registro O)
        {
        }

        public virtual void Atualizar (Registro O)
        {
        }

        public virtual void Apagar (int id)
        {
        }
        
        public virtual Registro Ler (int id)
        {
            return null;
        }
     }
}