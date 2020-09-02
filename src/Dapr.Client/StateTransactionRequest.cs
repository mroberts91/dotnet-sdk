﻿// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
// ------------------------------------------------------------

namespace Dapr
{
    using System.Collections.Generic;
    using System.Threading;
    using Dapr.Client;

    /// <summary>
    /// Represents a single request in in a StateTransaction.
    /// </summary>
    public sealed class StateTransactionRequest
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="StateTransactionRequest"/> class.
        /// </summary>
        /// <param name="key">The state key.</param>
        /// <param name="value">The serialized state value.</param>
        /// <param name="operationType">The operation type.</param>
        /// <param name="etag">The etag (optional).</param>
        /// <param name="metadata">Additional key value pairs for the state (optional).</param>
        /// <param name="options">State options (optional).</param>
        public StateTransactionRequest(string key, byte[] value, string operationType, string etag = default, Dictionary<string, string> metadata = default, StateOptions options = default)
        {
            ArgumentVerifier.ThrowIfNull(key, nameof(key));

            this.Key = key;
            this.Value = value;
            this.OperationType = operationType;
            this.ETag = etag;
            this.Metadata = metadata;
            this.Options = options;
        }


        /// <summary>
        /// Gets the state key.
        /// </summary>
        public string Key { get; }

        /// <summary>
        /// Gets or sets the value locally.
        /// </summary>
        public byte[] Value { get; set; }

        /// <summary>
        /// The Operation type.
        /// </summary>
        public string OperationType { get; set; }

        /// <summary>
        /// The ETag (optional).
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Additional key-value pairs to be passed to the state store (optional).
        /// </summary>
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// State Options (optional).
        /// </summary>
        public StateOptions Options { get; set; }
    }
}