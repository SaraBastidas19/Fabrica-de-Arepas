using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricadorArepas
{
    //abstract = no se puede crear instancias de esta clase . la clase se utiliza para definir estreucturalmente opciones más robustas en el proyecto
    public abstract class Arepa
    {
        //protected: no es ni privado ni público, puede ser manipulado dentro de esta clase y las otras
        protected string tipoDeMasa, tipoArepa;
        protected int diasCaducidad, numeroMolino;

        //constructor de la clase 
        /// <summary>
        /// Constructor predeterminado de la clase
        /// </summary>
        public Arepa()
        {

            /// <summary>
            /// Constructor con parámetros específicos
            /// </summary>
           
            tipoArepa = "";
            tipoDeMasa = "";
            diasCaducidad = 0;
            numeroMolino = 0;
        }

        //polimorfismo por sobrecarga para el constructor, método con dos versiones
        public Arepa(string tipoMasa, string tipoArepa, int diasCaducidad, int numeroMolino)
        {
           
            this.tipoArepa = tipoArepa;
            this.tipoDeMasa= tipoMasa;
            this.diasCaducidad = diasCaducidad;
            this.numeroMolino = numeroMolino;
        }

        public String GetTipoMasa()
        {
            return tipoDeMasa;
        }
        public void SetTipoMasa()
        {
            this.tipoDeMasa = tipoDeMasa;
        }

        public String GetTipoArepa()
        {
            return tipoArepa;
        }
        public void SetTipoArepa()
        {
            this.tipoArepa = tipoArepa;
        }

        public int GetDiasCaducidad()
        {
                return diasCaducidad;
        }
        public void SetDiasCaducidad()
        {
            if (diasCaducidad > 0)
            {
                this.diasCaducidad = diasCaducidad;
            }
            else 
                this.diasCaducidad = 0;
        }

        public int GetNumeroMolino()
        {
            return numeroMolino;
        }
        public void SetNumeroMolino()
        {
            this.numeroMolino = numeroMolino;
        }

        // define caracteristicas para heredar a clases similares
        public abstract string ObtieneInformacion();


    }
}
