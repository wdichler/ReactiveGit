﻿namespace ReactiveGit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents a item in the GIT ref log.
    /// </summary>
    public class GitRefLog : IGitIdObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GitRefLog"/> class.
        /// </summary>
        /// <param name="sha">The full length SHA.</param>
        /// <param name="shortSha">The short SHA id of the ref log item.</param>
        /// <param name="action">The action performed by the ref log item.</param>
        /// <param name="messageShort">The short message of the ref log item.</param>
        /// <param name="dateTime">The date time the ref log item happened.</param>
        public GitRefLog(string sha, string shortSha, string action, string messageShort, DateTime dateTime)
        {
            this.ShaShort = shortSha;
            this.Action = action;
            this.MessageShort = messageShort;
            this.DateTime = dateTime;
            this.Sha = sha;
        }

        /// <summary>
        /// Gets the short SHA id of the ref log item.
        /// </summary>
        public string ShaShort { get; }

        /// <inheritdoc />
        public string Sha { get; }

        /// <summary>
        /// Gets the action of the ref log item.
        /// </summary>
        public string Action { get; }

        /// <summary>
        /// Gets the short message of the ref log item.
        /// </summary>
        public string MessageShort { get; }

        /// <summary>
        /// Gets the date time when the ref log item happened.
        /// </summary>
        public DateTime DateTime { get; }
    }
}