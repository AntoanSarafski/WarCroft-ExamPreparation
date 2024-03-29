﻿using System;

using WarCroft.Constants;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
		// TODO: Implement the rest of the class.

		public bool IsAlive { get; set; } = true;

		private string name;

		public string Name
		{
			get { return name; }
			set
			{
				if (String.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException(ExceptionMessages.CharacterNameInvalid);
				}
				name = value;
			}
		}


		protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}
	}
}