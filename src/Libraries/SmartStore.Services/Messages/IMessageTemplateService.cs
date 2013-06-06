﻿using System.Collections.Generic;
using SmartStore.Core.Domain.Messages;

namespace SmartStore.Services.Messages
{
    /// <summary>
    /// Message template service
    /// </summary>
    public partial interface IMessageTemplateService
    {
        /// <summary>
        /// Inserts a message template
        /// </summary>
        /// <param name="messageTemplate">Message template</param>
        void InsertMessageTemplate(MessageTemplate messageTemplate);

        /// <summary>
        /// Updates a message template
        /// </summary>
        /// <param name="messageTemplate">Message template</param>
        void UpdateMessageTemplate(MessageTemplate messageTemplate);

        /// <summary>
        /// Gets a message template by identifier
        /// </summary>
        /// <param name="messageTemplateId">Message template identifier</param>
        /// <returns>Message template</returns>
        MessageTemplate GetMessageTemplateById(int messageTemplateId);

        /// <summary>
        /// Gets a message template by name
        /// </summary>
        /// <param name="messageTemplateName">Message template name</param>
		/// <param name="storeId">Store identifier</param>
        /// <returns>Message template</returns>
		MessageTemplate GetMessageTemplateByName(string messageTemplateName, int storeId);

        /// <summary>
        /// Gets all message templates
        /// </summary>
		/// <param name="storeId">Store identifier; pass 0 to load all records</param>
        /// <returns>Message template list</returns>
		IList<MessageTemplate> GetAllMessageTemplates(int storeId);
    }
}
