

namespace ClassLibrary
{
    public class Examenes : Evaluacion
    {

        private int _nota;
        public int Nota { set { _nota = value; }

        get{
                    if( _nota <= 0)
                {
                    
                    throw new Exception("La nota debe de ser mayor a cero");

                }
                    
            
            } }

        public string? NombreEstudiante { set; get; }

        private int _notafinal;
        public int CalificacionFinal { private get; set { _nota = value; } }

        public override void Evaluar()
        {
                        

        }
    }
}
