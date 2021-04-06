using System;
using System.Collections.Generic;

namespace DevBuildLab5_1
{
    class GameCharacter
    {
        private string characterName;
        private int strength;
        private int intelligence;

        public void CName (string name)
        {
            characterName = name;
        }

        public void CStrength (int characterStrength)
        {
            strength = characterStrength;
        }

        public void CIntelligence (int characterIntelligence)
        {
            intelligence = characterIntelligence;
        }

        public string GetcharacterName()
        {
            return characterName;
        }

        public int GetStrength()
        {
            return strength;
        }

        public int GetIntelligence()
        {
            return intelligence;
        }

        public virtual void Player()
        {
            // Console.WriteLine($"{characterName} a player (int {intelligence}, strength {strength}) weapon");
        }
    }

    class MagicUsingCharacter : GameCharacter
    {
        private int magicalEnergy;
        
        public override void  Player()
        {
            Console.WriteLine($"{GetcharacterName()} a player (int {GetIntelligence()}, strength {GetStrength()} magic {magicalEnergy})");
        }   

        public int GetMagicEnergy()
        {
            return magicalEnergy;
        }

        public void CMagicEnergy(int characterMagicEnergy)
        {
            magicalEnergy = characterMagicEnergy;
        }

    }

    class Warrior : GameCharacter
    {
        private string weaponType;

        public override void Player()
        {
            Console.WriteLine($"{GetcharacterName()} a player (int {GetIntelligence()}, strength {GetStrength()}) {weaponType}");
        }
        
        public void CWeaponType(string characterWeapon)
        {
            weaponType = characterWeapon;
        }
    }

    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public override void Player()
        {
            Console.WriteLine($"{GetcharacterName()} a player (intelligence {GetIntelligence()}, strength {GetStrength()} magic {GetMagicEnergy()}) {spellNumber} spells");
        }

        public void CSpellNumber(int characterSpellNumber)
        {
            spellNumber = characterSpellNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> GamePlayers = new List<GameCharacter>();
            List<Wizard> WPlayers = new List<Wizard>();
            List<Warrior> WarPlayers = new List<Warrior>();

            Wizard PlayerA = new Wizard();
            PlayerA.CName("Van");
            PlayerA.CStrength(9);
            PlayerA.CIntelligence(12);
            PlayerA.CMagicEnergy(7);
            PlayerA.CSpellNumber(87);

            Wizard PlayerB = new Wizard();
            PlayerB.CName("Mildred");
            PlayerB.CStrength(12);
            PlayerB.CIntelligence(7);
            PlayerB.CMagicEnergy(9);
            PlayerB.CSpellNumber(42);

            Warrior PlayerC = new Warrior();
            PlayerC.CName("Mikal");
            PlayerC.CStrength(14);
            PlayerC.CIntelligence(4);
            PlayerC.CWeaponType("Long Sword");

            Warrior PlayerD = new Warrior();
            PlayerD.CName("Ry-El");
            PlayerD.CStrength(21);
            PlayerD.CIntelligence(6);
            PlayerD.CWeaponType("Double Hammers");
            
            PlayerA.Player();
            PlayerB.Player();
            PlayerC.Player();
            PlayerD.Player();

           
        }
    }
}
