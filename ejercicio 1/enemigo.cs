using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_1
{
    class enemigo
    {
        public int posicionx { get; set; }
        public int posiciony { get; set; }
        private string _score;
        public string score
        {

            get
            {
                return _score;
               
            }

            set
            {
                if(value.Length >= 100 )
                {
                    _score = value;
                }
                
            }
        }


        public void moverse()
        {

        }

        public void disparar()
        {

        }

        public void explotar()
        {

        }
    }
}
