using System;
namespace Store.Domain.Entities
{
    public abstract class Entity
    {
        public int  Id { get; protected set; }

        // public Entity()
        // {
        //     Id = Guid.NewGuid();
        // }

        // //Testar performace com o uso do Guid SQL Server
        // public Guid Id { get;  set; }


        //Fazer comparação de ID's - USO OPCIONAL 
        // public bool Equals(Entity other)
        // {
        //     return Id == other.Id;
        // }
    }

}