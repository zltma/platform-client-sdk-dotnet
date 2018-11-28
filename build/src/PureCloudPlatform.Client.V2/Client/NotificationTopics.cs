using System;
using System.Collections.Generic;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Client
{
    public static class NotificationTopics
    {
        public static Dictionary<string, Type> Topics;

        static NotificationTopics()
        {
            Topics = new Dictionary<string, Type>
            { 
              {"v2.analytics.queues.{id}.observations", typeof(StatEventQueueTopicStatsNotification)},
              {"v2.analytics.users.{id}.aggregates", typeof(StatEventUserTopicStatsNotification)},
              {"v2.architect.dependencytracking.build", typeof(ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification)},
              {"v2.architect.prompts.{id}", typeof(ArchitectPromptNotificationPromptNotification)},
              {"v2.architect.prompts.{id}.resources.{id}", typeof(ArchitectPromptResourceNotificationPromptResourceNotification)},
              {"v2.architect.systemprompts.{id}.resources.{id}", typeof(ArchitectSystemPromptResourceNotificationSystemPromptResourceNotification)},
              {"v2.contentmanagement.documents.{id}", typeof(ContentManagementSingleDocumentTopicDocumentDataV2)},
              {"v2.contentmanagement.workspaces.{id}.documents", typeof(ContentManagementWorkspaceDocumentsTopicDocumentDataV2)},
              {"v2.flows.outcomes.{id}", typeof(ArchitectFlowOutcomeNotificationFlowOutcomeNotification)},
              {"v2.flows.{id}", typeof(ArchitectFlowNotificationFlowNotification)},
              {"v2.groups.{id}.greetings", typeof(GroupGreetingEventGreeting)},
              {"v2.managementunits.{id}.workforcemanagement.intraday", typeof(WfmIntradayDataUpdateTopicIntradayDataUpdate)},
              {"v2.outbound.attemptlimits.{id}", typeof(DialerAttemptLimitsConfigChangeAttemptLimits)},
              {"v2.outbound.callabletimesets.{id}", typeof(DialerCallabletimesetConfigChangeCallableTimeSet)},
              {"v2.outbound.campaignrules.{id}", typeof(DialerCampaignRuleConfigChangeCampaignRule)},
              {"v2.outbound.campaigns.{id}", typeof(DialerCampaignConfigChangeCampaign)},
              {"v2.outbound.campaigns.{id}.progress", typeof(DialerCampaignProgressEventCampaignProgress)},
              {"v2.outbound.campaigns.{id}.stats", typeof(StatEventCampaignTopicStatsNotification)},
              {"v2.outbound.contactlistfilters.{id}", typeof(DialerContactlistfilterConfigChangeContactListFilter)},
              {"v2.outbound.contactlists.{id}", typeof(DialerContactlistConfigChangeContactList)},
              {"v2.outbound.contactlists.{id}.importstatus", typeof(ContactlistImportStatusImportStatus)},
              {"v2.outbound.dnclists.{id}", typeof(DialerDnclistConfigChangeDncList)},
              {"v2.outbound.dnclists.{id}.importstatus", typeof(DnclistImportStatusImportStatus)},
              {"v2.outbound.responsesets.{id}", typeof(DialerResponsesetConfigChangeResponseSet)},
              {"v2.outbound.rulesets.{id}", typeof(DialerRulesetConfigChangeRuleSet)},
              {"v2.outbound.schedules.campaigns.{id}", typeof(DialerCampaignScheduleConfigChangeCampaignSchedule)},
              {"v2.outbound.schedules.sequences.{id}", typeof(DialerSequenceScheduleConfigChangeSequenceSchedule)},
              {"v2.outbound.sequences.{id}", typeof(DialerSequenceConfigChangeCampaignSequence)},
              {"v2.outbound.settings", typeof(DialerOutboundSettingsConfigChangeOutboundSettings)},
              {"v2.outbound.wrapupcodemappings.{id}", typeof(DialerWrapupcodemappingConfigChangeWrapUpCodeMapping)},
              {"v2.routing.queues.{id}.conversations", typeof(QueueConversationEventTopicConversation)},
              {"v2.routing.queues.{id}.conversations.callbacks", typeof(QueueConversationCallbackEventTopicCallbackConversation)},
              {"v2.routing.queues.{id}.conversations.calls", typeof(QueueConversationCallEventTopicCallConversation)},
              {"v2.routing.queues.{id}.conversations.chats", typeof(QueueConversationChatEventTopicChatConversation)},
              {"v2.routing.queues.{id}.conversations.cobrowseSessions", typeof(QueueConversationCobrowseEventTopicCobrowseConversation)},
              {"v2.routing.queues.{id}.conversations.emails", typeof(QueueConversationEmailEventTopicEmailConversation)},
              {"v2.routing.queues.{id}.conversations.messages", typeof(QueueConversationMessageEventTopicMessageConversation)},
              {"v2.routing.queues.{id}.conversations.screenshares", typeof(QueueConversationScreenShareEventTopicScreenShareConversation)},
              {"v2.routing.queues.{id}.conversations.socialexpressions", typeof(QueueConversationSocialExpressionEventTopicConversation)},
              {"v2.routing.queues.{id}.conversations.videos", typeof(QueueConversationVideoEventTopicConversation)},
              {"v2.routing.queues.{id}.users", typeof(QueueUserEventTopicQueueMember)},
              {"v2.system.{id}.{id}", typeof(SystemMessageSystemMessage)},
              {"v2.users.{id}.activity", typeof(AgentActivityChangedTopicAgentActivity)},
              {"v2.users.{id}.alerting.heartbeat.alerts", typeof(KlaxonHeartBeatAlertsTopicHeartBeatAlert)},
              {"v2.users.{id}.alerting.heartbeat.rules", typeof(KlaxonHeartBeatRulesTopicHeartBeatRule)},
              {"v2.users.{id}.alerting.interactionstats.alerts", typeof(KlaxonInteractionStatsAlertsTopicInteractionStatAlert)},
              {"v2.users.{id}.alerting.interactionstats.rules", typeof(KlaxonInteractionStatsRulesTopicInteractionStatRule)},
              {"v2.users.{id}.analytics.reporting.exports", typeof(ReportingDataExportTopicDataExportNotification)},
              {"v2.users.{id}.badges.chats", typeof(ChatBadgeTopicChatBadge)},
              {"v2.users.{id}.callforwarding", typeof(CallForwardingEventCallForwarding)},
              {"v2.users.{id}.conversations", typeof(ConversationEventTopicConversation)},
              {"v2.users.{id}.conversations.callbacks", typeof(ConversationCallbackEventTopicCallbackConversation)},
              {"v2.users.{id}.conversations.calls", typeof(ConversationCallEventTopicCallConversation)},
              {"v2.users.{id}.conversations.chats", typeof(ConversationChatEventTopicChatConversation)},
              {"v2.users.{id}.conversations.cobrowseSessions", typeof(ConversationCobrowseEventTopicCobrowseConversation)},
              {"v2.users.{id}.conversations.emails", typeof(ConversationEmailEventTopicEmailConversation)},
              {"v2.users.{id}.conversations.messages", typeof(ConversationMessageEventTopicMessageConversation)},
              {"v2.users.{id}.conversations.screenshares", typeof(ConversationScreenShareEventTopicScreenShareConversation)},
              {"v2.users.{id}.conversations.socialexpressions", typeof(ConversationSocialExpressionEventTopicSocialConversation)},
              {"v2.users.{id}.conversations.videos", typeof(ConversationVideoEventTopicVideoConversation)},
              {"v2.users.{id}.conversationsummary", typeof(UserConversationsEventUserConversationSummary)},
              {"v2.users.{id}.fax.documents", typeof(FaxTopicFaxDataV2)},
              {"v2.users.{id}.geolocation", typeof(GeolocationEventGeolocation)},
              {"v2.users.{id}.greetings", typeof(UserGreetingEventGreeting)},
              {"v2.users.{id}.outbound.contactlists.{id}.export", typeof(ContactlistDownloadReadyExportUri)},
              {"v2.users.{id}.outbound.dnclists.{id}.export", typeof(DnclistDownloadReadyExportUri)},
              {"v2.users.{id}.outofoffice", typeof(OutOfOfficeEventOutOfOffice)},
              {"v2.users.{id}.presence", typeof(PresenceEventUserPresence)},
              {"v2.users.{id}.routingStatus", typeof(UserRoutingStatusUserRoutingStatus)},
              {"v2.users.{id}.station", typeof(UserStationChangeTopicUserStations)},
              {"v2.users.{id}.userrecordings", typeof(AdhocRecordingTopicRecordingDataV2)},
              {"v2.users.{id}.voicemail.messages", typeof(VoicemailMessagesTopicVoicemailMessage)},
              {"v2.users.{id}.workforcemanagement.adherence", typeof(WfmUserScheduleAdherenceUpdatedTopicUserScheduleAdherenceUpdate)},
              {"v2.users.{id}.workforcemanagement.historicaladherencequery", typeof(WfmHistoricalAdherenceCalculationsCompleteTopicWfmHistoricalAdherenceCalculationsCompleteNotice)},
              {"v2.users.{id}.workforcemanagement.schedules", typeof(WfmAgentScheduleUpdateTopicWfmAgentScheduleUpdateNotification)},
              {"v2.users.{id}.workforcemanagement.timeoffrequests", typeof(WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate)},
              {"v2.workforcemanagement.agents", typeof(WfmMoveAgentsCompleteTopicWfmMoveAgentsComplete)},
              {"v2.workforcemanagement.managementunits.{id}.agents.sync", typeof(WfmUpdateAgentDetailsTopicWfmUpdateAgentDetailsComplete)},
              {"v2.workforcemanagement.managementunits.{id}.schedules", typeof(WfmScheduleTopicWfmScheduleNotification)},
            };
        }
    }
}