// -----------------------------------------------------------------------
// <copyright file="PlayingFootstepEventArgs.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Events.EventArgs.Scp939
{
    using API.Features;
    using Exiled.API.Features.Roles;
    using Interfaces;

    /// <summary>
    /// Contains all information before the footsteps are being shown to SCP-939.
    /// </summary>
    public class PlayingFootstepEventArgs : IScp939Event, IDeniableEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayingFootstepEventArgs" /> class.
        /// </summary>
        /// <param name="player">
        /// The target being shown to SCP-939.
        /// </param>
        /// <param name="scp939">
        /// The player who's controlling SCP-939.
        /// </param>
        /// <param name="isAllowed">
        /// Indicates whether the footstep action is allowed.
        /// </param>
        public PlayingFootstepEventArgs(Player player, Player scp939, bool isAllowed = true)
        {
            Player = player;
            Scp939 = scp939.Role.As<Scp939Role>();
            IsAllowed = isAllowed;
        }

        /// <summary>
        /// Gets the target being shown to SCP-939.
        /// </summary>
        public Player Player { get; }

        /// <inheritdoc/>
        /// <summary>
        /// Gets the player who's controlling SCP-939.
        /// </summary>
        public Scp939Role Scp939 { get; }

        /// <summary>
        /// Gets or sets a value indicating whether footsteps are visible.
        /// </summary>
        public bool IsAllowed { get; set; }
    }
}
