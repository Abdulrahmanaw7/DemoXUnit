using GameEngine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DemoXUnit.Test
{
    public class PlayerCharacterShould
    {
        #region Strings

        [Fact]
        public void BeInExperiencedWhenNew()
        {
            PlayerCharacter sut = new PlayerCharacter();
            Assert.True(sut.IsNoob);
        }
        [Fact]
        public void FullNameCollect()
        {
            PlayerCharacter sut = new PlayerCharacter();
            sut.FirstName = "Abdulrahman";
            sut.LastName = "Ahmed";
            Assert.Equal("Abdulrahman Ahmed", sut.FullName);

        }
        [Fact]
        public void FullnameStartingWithirstName()
        {
            PlayerCharacter sut = new PlayerCharacter();
            sut.FirstName = "Abdulrahman";
            sut.LastName = "Ahmed";
            Assert.StartsWith("Abdulrahman", sut.FirstName);

        }
        [Fact]
        public void FullnameEndingWithLastName()
        {
            PlayerCharacter sut = new PlayerCharacter();
            sut.FirstName = "Abdulrahman";
            sut.LastName = "Ahmed";
            Assert.EndsWith("Ahmed", sut.LastName);

        }
        [Fact]
        public void FullnameCase()
        {
            PlayerCharacter sut = new PlayerCharacter();
            sut.FirstName = "ABULRAHMAN";
            sut.LastName = "AHMED";
            Assert.Equal("ABULRAHMAN AHMED", sut.FullName);

        }
        [Fact]
        public void FullnameIgnoreCase()
        {
            PlayerCharacter sut = new PlayerCharacter();
            sut.FirstName = "ABDULRAHMAN";
            sut.LastName = "AHMED";
            Assert.Equal("Abdulrahman Ahmed", sut.FullName, ignoreCase: true);

        }
        [Fact]
        public void FullnameContains()
        {
            PlayerCharacter sut = new PlayerCharacter();
            sut.FirstName = "Abdulrahman";
            sut.LastName = "Ahmed";
            Assert.Contains("an Ah", sut.FullName);

        }

        [Fact]
        public void FullnameMatches()
        {
            PlayerCharacter sut = new PlayerCharacter();
            sut.FirstName = "Abdulrahman";
            sut.LastName = "Ahmed";
            // take care about spaces in matching Expression
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", sut.FullName);

        }
        #endregion

        #region Numeric And Floating Points Value
        [Fact]
        public void EqualValueHealth()
        {
            PlayerCharacter sut = new PlayerCharacter();
            Assert.Equal(100, sut.Health);
        }

        [Fact]
        public void NotEqualValueHealth()
        {
            PlayerCharacter sut = new PlayerCharacter();
            Assert.NotEqual(0, sut.Health);
        }
        [Fact]
        public void RangeInValueHealthWithRange()
        {
            PlayerCharacter sut = new PlayerCharacter();
            sut.Sleep();
            Assert.InRange(sut.Health, 1, 200);
            // Assert.True(sut.Health >= 100 && sut.Health <= 200);
        }
        [Fact]
        public void RangeInValueHealthWithTrue()
        {
            PlayerCharacter sut = new PlayerCharacter();
            sut.Sleep();
            // Assert.InRange(sut.Health, 1, 200);
            Assert.True(sut.Health >= 100 && sut.Health <= 200);
        }
        #endregion
    }
}
