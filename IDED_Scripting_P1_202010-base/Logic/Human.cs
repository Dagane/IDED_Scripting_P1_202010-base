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
            //Para que el soldier y el squire cambien
            if (UnitClass.Equals(EUnitClass.Soldier) && newClass == EUnitClass.Squire)
            {
                return true;
            }
            else if (UnitClass.Equals(EUnitClass.Squire) && newClass == EUnitClass.Soldier)
            {
                return true;
            }

            //Para que el ranger y el mage cambien
            else if (UnitClass.Equals(EUnitClass.Ranger) && newClass == EUnitClass.Mage)
            {
                return true;
            }
            else if (UnitClass.Equals(EUnitClass.Mage) && newClass == EUnitClass.Ranger)
            {
                return true;
            }
            else { return false; }
 
            
        }


        public void Humano(EUnitClass a)
        {
            
            if (a==EUnitClass.Soldier||a==EUnitClass.Mage||a==EUnitClass.Squire||a==EUnitClass.Ranger)
            {
                if (( Defense * Potential) > 255)
                {
                    Defense = Defense * Potential;
                }
                else { Attack = 255; }

                if ((Speed * Potential) > 255)
                {
                    Speed = Speed* Potential;
                }
                else { Attack = 255; }

                if (( Attack * Potential) > 255)
                {
                    Attack = Attack * Potential;
                }
                else { Attack = 255; }

            }
        }
    }
}