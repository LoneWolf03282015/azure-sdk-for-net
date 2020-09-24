// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of common properties of all chat events. </summary>
    public partial class ACSChatEventBaseProperties
    {
        /// <summary> Initializes a new instance of ACSChatEventBaseProperties. </summary>
        internal ACSChatEventBaseProperties()
        {
        }

        /// <summary> Initializes a new instance of ACSChatEventBaseProperties. </summary>
        /// <param name="recipientId"> The MRI of the target user. </param>
        /// <param name="transactionId"> The transaction id will be used as co-relation vector. </param>
        /// <param name="threadId"> The chat thread id. </param>
        internal ACSChatEventBaseProperties(string recipientId, string transactionId, string threadId)
        {
            RecipientId = recipientId;
            TransactionId = transactionId;
            ThreadId = threadId;
        }

        /// <summary> The MRI of the target user. </summary>
        public string RecipientId { get; }
        /// <summary> The transaction id will be used as co-relation vector. </summary>
        public string TransactionId { get; }
        /// <summary> The chat thread id. </summary>
        public string ThreadId { get; }
    }
}