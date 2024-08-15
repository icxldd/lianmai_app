﻿using Elsa;
using Elsa.ActivityResults;
using Elsa.Attributes;
using Elsa.Services.Models;
using LINGYUN.Abp.IM.Messages;
using System;
using System.Threading.Tasks;
using Volo.Abp.Timing;

namespace LINGYUN.Abp.Elsa.Activities.IM;

[Action(
    Category = "Message",
    Description = "Send an message.",
    Outcomes = new[] { OutcomeNames.Done })]
public class SendMessage : AbpActivity
{
    private readonly IClock _clock;
    private readonly IMessageSender _messageSender;

    [ActivityInput(Hint = "The message content.")]
    public string Content { get; set; } //TODO: Other message type

    [ActivityInput(Hint = "Source user identity.")]
    public Guid FormUser { get; set; }

    [ActivityInput(Hint = "Source user name.")]
    public string? FormUserName { get; set; }

    [ActivityInput(
        Hint = "Receiving user identity.",
        UIHint = "If the value is not empty, it is a user message")]
    public Guid? To { get; set; }

    [ActivityInput(
        Hint = "Receiving group identity.",
        UIHint = "If the value is not empty, it is a group message")]
    public string? GroupId { get; set; }

    [ActivityOutput]
    public string? MessageId { get; set; }

    public SendMessage(
        IClock clock,
        IMessageSender messageSender)
    {
        _clock = clock;
        _messageSender = messageSender;
    }


    protected async override ValueTask<IActivityExecutionResult> OnActivityExecuteAsync(ActivityExecutionContext context)
    {
        ChatMessage? chatMessage = null;

        if (!GroupId.IsNullOrWhiteSpace())
        {
            chatMessage = ChatMessage.Group(
                FormUser,
                FormUserName,
                GroupId,
                Content,
                _clock,
                false,
                MessageType.Text,
                MessageSourceType.User,
                TenantId);
        }
        else if (To.HasValue)
        {
            chatMessage = ChatMessage.User(
               FormUser,
               FormUserName,
               To.Value,
               Content,
               _clock,
               false,
               MessageType.Text,
               MessageSourceType.User,
               TenantId);
        }

        if (chatMessage != null)
        {
            MessageId = await _messageSender.SendMessageAsync(chatMessage);

            return Done();
        }

        return Suspend();
    }
}
