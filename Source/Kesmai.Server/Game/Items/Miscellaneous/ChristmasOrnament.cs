﻿using System;
using System.Collections.Generic;
using System.IO;
using Kesmai.Server.Game;
using Kesmai.Server.Network;

namespace Kesmai.Server.Items
{
	public partial class ChristmasOrnament : ItemEntity, ITreasure
	{
		/// <inheritdoc />
		public override int LabelNumber => 6000066;

		/// <inheritdoc />
		public override uint BasePrice => 250000;

		/// <inheritdoc />
		public override int Weight => 15;

		/// <inheritdoc />
		public override int Category => 3;

		/// <summary>
		/// Initializes a new instance of the <see cref="ChristmasOrnament"/> class.
		/// </summary>
		public ChristmasOrnament() : base(323)
		{
		}

		/// <inheritdoc />
		public override void GetDescription(List<LocalizationEntry> entries)
		{
			entries.Add(new LocalizationEntry(6200000, 6200338)); /* [You are looking at] [an ornament used for decorating holiday trees.] */
		}
	}
}