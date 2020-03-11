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
            //control para que nadie me joda al villager
            if (UnitClass.Equals(EUnitClass.Soldier) && otherUnit.UnitClass==EUnitClass.Villager)
            {
                return false;
            }
            if (UnitClass.Equals(EUnitClass.Squire) && otherUnit.UnitClass == EUnitClass.Villager)
            {
                return false;
            }
            if (UnitClass.Equals(EUnitClass.Mage) && otherUnit.UnitClass == EUnitClass.Villager)
            {
                return false;
            }
            if (UnitClass.Equals(EUnitClass.Ranger) && otherUnit.UnitClass == EUnitClass.Villager)
            {
                return false;
            }
            if (UnitClass.Equals(EUnitClass.Imp) && otherUnit.UnitClass == EUnitClass.Villager)
            {
                return false;
            }
            if (UnitClass.Equals(EUnitClass.Orc) && otherUnit.UnitClass == EUnitClass.Villager)
            {
                return false;
            }
            if (UnitClass.Equals(EUnitClass.Dragon) && otherUnit.UnitClass == EUnitClass.Villager)
            {
                return false;
            }

            //Para que el villager no joda
            if (UnitClass.Equals(EUnitClass.Villager) && otherUnit.UnitClass == EUnitClass.Squire)
            {
                return false;
            }
            if (UnitClass.Equals(EUnitClass.Villager) && otherUnit.UnitClass == EUnitClass.Soldier)
            {
                return false;
            }
            if (UnitClass.Equals(EUnitClass.Villager) && otherUnit.UnitClass == EUnitClass.Villager)
            {
                return false;
            }

            //Para que el mago no joda
            if (UnitClass.Equals(EUnitClass.Mage) && otherUnit.UnitClass == EUnitClass.Mage)
            {
                return false;
            }
            if (UnitClass.Equals(EUnitClass.Mage) && otherUnit.UnitClass == EUnitClass.Ranger)
            {
                return false;
            }

            //Para que el dragon no joda
            if (UnitClass.Equals(EUnitClass.Dragon) && otherUnit.UnitClass == EUnitClass.Ranger)
            {
                return false;
            }
            if (UnitClass.Equals(EUnitClass.Dragon) && otherUnit.UnitClass == EUnitClass.Imp)
            {
                return false;
            }
            if (UnitClass.Equals(EUnitClass.Dragon) && otherUnit.UnitClass == EUnitClass.Orc)
            {
                return false;
            }

            return true;
        }



        //Interaccion con props
        public virtual bool Interact(Prop prop)
        {
            if (UnitClass == EUnitClass.Villager)
            {
                return true;
            }
            else { return false; }
        }


        //Si se mueve o no
        public bool Move(Position targetPosition)
        {
            if (CurrentPosition.x + MoveRange <= targetPosition.x && CurrentPosition.y + MoveRange <= targetPosition.y)
            {
                CurrentPosition = targetPosition;
                return true;
            }
            else { return false; }

        }


        public void UnitCaracteristicas()
        {
            //Condiciones movimiento 
            if (1 > MoveRange && 10 < MoveRange) { MoveRange = MoveRange; }
            else if (MoveRange > 1) { MoveRange = 1; }
            else if (MoveRange < 10) { MoveRange = 10; }



            //Bases
            if (BaseAtk < 225 && BaseAtk > 0)
            {
                BaseAtk = BaseAtk;
            }
            else { BaseAtk = 255; }

            if (BaseDef< 225 && BaseDef > 0)
            {
                BaseDef = BaseDef;
            }
            else { BaseAtk = 255; }

            if (BaseSpd < 225 && BaseSpd > 0)
            {
                BaseSpd = BaseSpd;
            }
            else { BaseAtk = 255; }



            //asignacion de atributos
            if (UnitClass == EUnitClass.Villager)
            {
                Attack = 0;
                Defense= 0;
                Speed = 0;
                AtkRange = 0;

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
                AtkRange = 1;

            }
            if (UnitClass == EUnitClass.Soldier)
            {
                BaseAtkAdd = 0.3f;
                BaseDefAdd = 0.2f;
                BaseSpdAdd = 0.1f;
                AtkRange = 1;

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
                AtkRange = 1;

            }
            if (UnitClass == EUnitClass.Orc)
            {
                BaseAtkAdd = 0.4f;
                BaseDefAdd = 0.2f;
                BaseSpdAdd = -0.2f;
                AtkRange = 1;
            }
            if (UnitClass == EUnitClass.Dragon)
            {
                BaseAtkAdd = 0.5f;
                BaseDefAdd = 0.3f;
                BaseSpdAdd = 0.2f;
                AtkRange = 5;

            }


            //Caracteristicas
            if(BaseAtk * BaseAtkAdd < 255)
            {
                Attack = 255;
            }
            else { Attack = BaseAtk * BaseAtkAdd; }

            if (BaseDef * BaseDefAdd < 255)
            {
                Defense = 255;
            }
            else { Defense = BaseDef * BaseDefAdd; }

            if (BaseSpd * BaseSpdAdd < 255)
            {
                Speed = 255;
            }
            else { Speed = BaseSpd * BaseSpdAdd; }


        }

        public void move(Position newposition)
        {
            
            
        }


    }
}