namespace IDED_Scripting_P1_202010_base.Logic
{
    public class Human : Unit
    {
        public float Potential { get; set; }

        public Human(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange, float _potential)
            : base(_unitClass, _atk, _def, _spd, _moveRange)
        {
            
            if (Potential<0.1 && Potential >0)
            {
                Potential = _potential;
            }
            
            
        }
        
        public virtual bool ChangeClass(EUnitClass newClass)
        {
            return false;
        }


        public void Humano(EUnitClass a)
        {
            if (a is Human)
            {
              
                

                if ((Defense += Defense * Potential) > 255)
                {
                    Defense += Defense * Potential;
                }
                else { Attack = 255; }

                if ((Speed += Speed * Potential) > 255)
                {
                    Speed += Speed* Potential;
                }
                else { Attack = 255; }

                if ((Attack += Attack * Potential) > 255)
                {
                    Attack += Attack * Potential;
                }
                else { Attack = 255; }

            }
        }
    }
}