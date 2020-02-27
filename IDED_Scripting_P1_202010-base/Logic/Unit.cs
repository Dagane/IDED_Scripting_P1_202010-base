namespace IDED_Scripting_P1_202010_base.Logic
{
    public class Unit
    {
        public float BaseAtk { get; protected set; }
        public float BaseDef { get; protected set; }
        public float  BaseSpd { get; protected set; }

        public int MoveRange { get; protected set; }
        public int AtkRange { get; protected set; }

        public float BaseAtkAdd { get; protected set; }
        public float BaseDefAdd { get; protected set; }
        public float BaseSpdAdd { get; protected set; }

        public float Attack { get; protected set; }
        public float Defense { get; protected set; }
        public float Speed { get; protected set; }

        protected Position CurrentPosition;

        public EUnitClass UnitClass { get; protected set; }

        public Unit(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange)
        {
            UnitClass = _unitClass;
            BaseAtk = _atk;
            BaseDef = _def;
            BaseSpd = _spd;
            MoveRange = _moveRange;

        }

        public virtual bool Interact(Unit otherUnit)
        {
            
            return false;
        }

        public virtual bool Interact(Prop prop) => false;

        public bool Move(Position targetPosition) => false;


        public void UnitCaracteristicas()
        {
            if (BaseAtk < 225 && BaseAtk > 0)
            {
                BaseAtk = BaseAtk;
            }
            if (BaseDef< 225 && BaseDef > 0)
            {
                BaseDef = BaseDef;
            }
            if (BaseSpd < 225 && BaseSpd > 0)
            {
                BaseSpd = BaseSpd;
            }


            if (UnitClass == EUnitClass.Ranger)
            {
                BaseAtkAdd = 0.1f;
                BaseDefAdd = 0.0f;
                BaseSpdAdd = 0.3f;
                AtkRange = 3;

            }
            if (UnitClass == EUnitClass.Squire)
            {
                BaseAtkAdd = 0.2f;
                BaseDefAdd = 0.1f;
                BaseSpdAdd = 0.0f;

            }
            if (UnitClass == EUnitClass.Soldier)
            {
                BaseAtkAdd = 0.3f;
                BaseDefAdd = 0.2f;
                BaseSpdAdd = 0.1f;

            }
            if (UnitClass == EUnitClass.Mage)
            {
                BaseAtkAdd = 0.3f;
                BaseDefAdd = 0.1f;
                BaseSpdAdd = -0.1f;
                AtkRange = 3;

            }
            if (UnitClass == EUnitClass.Imp)
            {
                BaseAtkAdd = 0.1f;
                BaseDefAdd = 0.0f;
                BaseSpdAdd = 0.0f;

            }
            if (UnitClass == EUnitClass.Orc)
            {
                BaseAtkAdd = 0.4f;
                BaseDefAdd = 0.2f;
                BaseSpdAdd = -0.2f;

            }
            if (UnitClass == EUnitClass.Dragon)
            {
                BaseAtkAdd = 0.5f;
                BaseDefAdd = 0.3f;
                BaseSpdAdd = 0.2f;
                AtkRange = 5;

            }

            if((BaseAtk + (BaseAtk * BaseAtkAdd) < 255))
            {
                Attack = 255;
            }
            else { Attack = BaseAtk + (BaseAtk * BaseAtkAdd); }

            if ((BaseDef + (BaseDef * BaseDefAdd) < 255))
            {
                Defense = 255;
            }
            else { Defense = BaseDef + (BaseDef * BaseDefAdd); }

            if ((BaseSpd + (BaseSpd * BaseSpdAdd) < 255))
            {
                Speed = 255;
            }
            else { Speed = BaseSpd + (BaseSpd * BaseSpdAdd); }


        }




    }
}