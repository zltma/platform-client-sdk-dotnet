using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWorkforceManagementApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns></returns>
        void DeleteWorkforcemanagementManagementunit (string muId);

        /// <summary>
        /// Delete management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkforcemanagementManagementunitWithHttpInfo (string muId);
        
        /// <summary>
        /// Deletes an activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to delete</param>
        /// <returns></returns>
        void DeleteWorkforcemanagementManagementunitActivitycode (string muId, string acId);

        /// <summary>
        /// Deletes an activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkforcemanagementManagementunitActivitycodeWithHttpInfo (string muId, string acId);
        
        /// <summary>
        /// Cancel a schedule run
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns></returns>
        void DeleteWorkforcemanagementManagementunitSchedulingRun (string managementUnitId, string runId);

        /// <summary>
        /// Cancel a schedule run
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkforcemanagementManagementunitSchedulingRunWithHttpInfo (string managementUnitId, string runId);
        
        /// <summary>
        /// Delete a service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to delete</param>
        /// <returns></returns>
        void DeleteWorkforcemanagementManagementunitServicegoalgroup (string managementUnitId, string serviceGoalGroupId);

        /// <summary>
        /// Delete a service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkforcemanagementManagementunitServicegoalgroupWithHttpInfo (string managementUnitId, string serviceGoalGroupId);
        
        /// <summary>
        /// Delete a schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of theschedule to delete</param>
        /// <returns></returns>
        void DeleteWorkforcemanagementManagementunitWeekSchedule (string managementUnitId, string weekId, string scheduleId);

        /// <summary>
        /// Delete a schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of theschedule to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkforcemanagementManagementunitWeekScheduleWithHttpInfo (string managementUnitId, string weekId, string scheduleId);
        
        /// <summary>
        /// Delete a short term forecast
        /// </summary>
        /// <remarks>
        /// Must not be tied to any schedules
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <returns></returns>
        void DeleteWorkforcemanagementManagementunitWeekShorttermforecast (string managementUnitId, string weekDateId, string forecastId);

        /// <summary>
        /// Delete a short term forecast
        /// </summary>
        /// <remarks>
        /// Must not be tied to any schedules
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkforcemanagementManagementunitWeekShorttermforecastWithHttpInfo (string managementUnitId, string weekDateId, string forecastId);
        
        /// <summary>
        /// Delete a work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to delete</param>
        /// <returns></returns>
        void DeleteWorkforcemanagementManagementunitWorkplan (string managementUnitId, string workPlanId);

        /// <summary>
        /// Delete a work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkforcemanagementManagementunitWorkplanWithHttpInfo (string managementUnitId, string workPlanId);
        
        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>List&lt;UserScheduleAdherence&gt;</returns>
        List<UserScheduleAdherence> GetWorkforcemanagementAdherence (List<string> userId);

        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>ApiResponse of List&lt;UserScheduleAdherence&gt;</returns>
        ApiResponse<List<UserScheduleAdherence>> GetWorkforcemanagementAdherenceWithHttpInfo (List<string> userId);
        
        /// <summary>
        /// Get management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>ManagementUnit</returns>
        ManagementUnit GetWorkforcemanagementManagementunit (string muId, string expand = null);

        /// <summary>
        /// Get management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>ApiResponse of ManagementUnit</returns>
        ApiResponse<ManagementUnit> GetWorkforcemanagementManagementunitWithHttpInfo (string muId, string expand = null);
        
        /// <summary>
        /// Get an activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to fetch</param>
        /// <returns>ActivityCode</returns>
        ActivityCode GetWorkforcemanagementManagementunitActivitycode (string muId, string acId);

        /// <summary>
        /// Get an activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to fetch</param>
        /// <returns>ApiResponse of ActivityCode</returns>
        ApiResponse<ActivityCode> GetWorkforcemanagementManagementunitActivitycodeWithHttpInfo (string muId, string acId);
        
        /// <summary>
        /// Get activity codes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ActivityCodeContainer</returns>
        ActivityCodeContainer GetWorkforcemanagementManagementunitActivitycodes (string muId);

        /// <summary>
        /// Get activity codes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of ActivityCodeContainer</returns>
        ApiResponse<ActivityCodeContainer> GetWorkforcemanagementManagementunitActivitycodesWithHttpInfo (string muId);
        
        /// <summary>
        /// Get data for agent in the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The id of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="agentId">The agent id</param>
        /// <returns>WfmAgent</returns>
        WfmAgent GetWorkforcemanagementManagementunitAgent (string managementUnitId, string agentId);

        /// <summary>
        /// Get data for agent in the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The id of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="agentId">The agent id</param>
        /// <returns>ApiResponse of WfmAgent</returns>
        ApiResponse<WfmAgent> GetWorkforcemanagementManagementunitAgentWithHttpInfo (string managementUnitId, string agentId);
        
        /// <summary>
        /// Get intraday queues for the given date
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="date">yyyy-MM-dd date string interpreted in the configured management unit time zone</param>
        /// <returns>WfmIntradayQueueListing</returns>
        WfmIntradayQueueListing GetWorkforcemanagementManagementunitIntradayQueues (string muId, string date);

        /// <summary>
        /// Get intraday queues for the given date
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="date">yyyy-MM-dd date string interpreted in the configured management unit time zone</param>
        /// <returns>ApiResponse of WfmIntradayQueueListing</returns>
        ApiResponse<WfmIntradayQueueListing> GetWorkforcemanagementManagementunitIntradayQueuesWithHttpInfo (string muId, string date);
        
        /// <summary>
        /// Gets the status for a specific scheduling run
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>SchedulingRunResponse</returns>
        SchedulingRunResponse GetWorkforcemanagementManagementunitSchedulingRun (string managementUnitId, string runId);

        /// <summary>
        /// Gets the status for a specific scheduling run
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>ApiResponse of SchedulingRunResponse</returns>
        ApiResponse<SchedulingRunResponse> GetWorkforcemanagementManagementunitSchedulingRunWithHttpInfo (string managementUnitId, string runId);
        
        /// <summary>
        /// Gets the result of a specific scheduling run
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>RescheduleResult</returns>
        RescheduleResult GetWorkforcemanagementManagementunitSchedulingRunResult (string managementUnitId, string runId);

        /// <summary>
        /// Gets the result of a specific scheduling run
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>ApiResponse of RescheduleResult</returns>
        ApiResponse<RescheduleResult> GetWorkforcemanagementManagementunitSchedulingRunResultWithHttpInfo (string managementUnitId, string runId);
        
        /// <summary>
        /// Get the status of all the ongoing schedule runs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <returns>SchedulingRunListResponse</returns>
        SchedulingRunListResponse GetWorkforcemanagementManagementunitSchedulingRuns (string managementUnitId);

        /// <summary>
        /// Get the status of all the ongoing schedule runs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <returns>ApiResponse of SchedulingRunListResponse</returns>
        ApiResponse<SchedulingRunListResponse> GetWorkforcemanagementManagementunitSchedulingRunsWithHttpInfo (string managementUnitId);
        
        /// <summary>
        /// Get a service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to fetch</param>
        /// <returns>ServiceGoalGroup</returns>
        ServiceGoalGroup GetWorkforcemanagementManagementunitServicegoalgroup (string managementUnitId, string serviceGoalGroupId);

        /// <summary>
        /// Get a service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to fetch</param>
        /// <returns>ApiResponse of ServiceGoalGroup</returns>
        ApiResponse<ServiceGoalGroup> GetWorkforcemanagementManagementunitServicegoalgroupWithHttpInfo (string managementUnitId, string serviceGoalGroupId);
        
        /// <summary>
        /// Get service goal groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ServiceGoalGroupList</returns>
        ServiceGoalGroupList GetWorkforcemanagementManagementunitServicegoalgroups (string managementUnitId);

        /// <summary>
        /// Get service goal groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of ServiceGoalGroupList</returns>
        ApiResponse<ServiceGoalGroupList> GetWorkforcemanagementManagementunitServicegoalgroupsWithHttpInfo (string managementUnitId);
        
        /// <summary>
        /// Get the settings for the requested management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ManagementUnitSettings</returns>
        ManagementUnitSettings GetWorkforcemanagementManagementunitSettings (string muId);

        /// <summary>
        /// Get the settings for the requested management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of ManagementUnitSettings</returns>
        ApiResponse<ManagementUnitSettings> GetWorkforcemanagementManagementunitSettingsWithHttpInfo (string muId);
        
        /// <summary>
        /// Get a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>TimeOffRequestResponse</returns>
        TimeOffRequestResponse GetWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId);

        /// <summary>
        /// Get a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>ApiResponse of TimeOffRequestResponse</returns>
        ApiResponse<TimeOffRequestResponse> GetWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo (string muId, string userId, string timeOffRequestId);
        
        /// <summary>
        /// Get a list of time off requests for a given user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>TimeOffRequestList</returns>
        TimeOffRequestList GetWorkforcemanagementManagementunitUserTimeoffrequests (string muId, string userId, bool? recentlyReviewed = null);

        /// <summary>
        /// Get a list of time off requests for a given user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>ApiResponse of TimeOffRequestList</returns>
        ApiResponse<TimeOffRequestList> GetWorkforcemanagementManagementunitUserTimeoffrequestsWithHttpInfo (string muId, string userId, bool? recentlyReviewed = null);
        
        /// <summary>
        /// Get users in the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>WfmUserEntityListing</returns>
        WfmUserEntityListing GetWorkforcemanagementManagementunitUsers (string muId);

        /// <summary>
        /// Get users in the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of WfmUserEntityListing</returns>
        ApiResponse<WfmUserEntityListing> GetWorkforcemanagementManagementunitUsersWithHttpInfo (string muId);
        
        /// <summary>
        /// Get a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>WeekScheduleResponse</returns>
        WeekScheduleResponse GetWorkforcemanagementManagementunitWeekSchedule (string managementUnitId, string weekId, string scheduleId, string expand = null, bool? forceDownloadService = null);

        /// <summary>
        /// Get a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>ApiResponse of WeekScheduleResponse</returns>
        ApiResponse<WeekScheduleResponse> GetWorkforcemanagementManagementunitWeekScheduleWithHttpInfo (string managementUnitId, string weekId, string scheduleId, string expand = null, bool? forceDownloadService = null);
        
        /// <summary>
        /// Get week schedule generation results
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch generation results</param>
        /// <returns>WeekScheduleGenerationResult</returns>
        WeekScheduleGenerationResult GetWorkforcemanagementManagementunitWeekScheduleGenerationresults (string managementUnitId, string weekId, string scheduleId);

        /// <summary>
        /// Get week schedule generation results
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch generation results</param>
        /// <returns>ApiResponse of WeekScheduleGenerationResult</returns>
        ApiResponse<WeekScheduleGenerationResult> GetWorkforcemanagementManagementunitWeekScheduleGenerationresultsWithHttpInfo (string managementUnitId, string weekId, string scheduleId);
        
        /// <summary>
        /// Get the list of schedules in a week in management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <returns>WeekScheduleListResponse</returns>
        WeekScheduleListResponse GetWorkforcemanagementManagementunitWeekSchedules (string managementUnitId, string weekId);

        /// <summary>
        /// Get the list of schedules in a week in management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <returns>ApiResponse of WeekScheduleListResponse</returns>
        ApiResponse<WeekScheduleListResponse> GetWorkforcemanagementManagementunitWeekSchedulesWithHttpInfo (string managementUnitId, string weekId);
        
        /// <summary>
        /// Get the final result of a short term forecast calculation with modifications applied
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>ForecastResultResponse</returns>
        ForecastResultResponse GetWorkforcemanagementManagementunitWeekShorttermforecastFinal (string managementUnitId, string weekDateId, string forecastId, bool? forceDownloadService = null);

        /// <summary>
        /// Get the final result of a short term forecast calculation with modifications applied
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>ApiResponse of ForecastResultResponse</returns>
        ApiResponse<ForecastResultResponse> GetWorkforcemanagementManagementunitWeekShorttermforecastFinalWithHttpInfo (string managementUnitId, string weekDateId, string forecastId, bool? forceDownloadService = null);
        
        /// <summary>
        /// Get short term forecasts
        /// </summary>
        /// <remarks>
        /// Use \&quot;recent\&quot; for the `weekDateId` path parameter to fetch all forecasts for +/- 26 weeks from the current date
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <returns>ShortTermForecastListResponse</returns>
        ShortTermForecastListResponse GetWorkforcemanagementManagementunitWeekShorttermforecasts (string managementUnitId, string weekDateId);

        /// <summary>
        /// Get short term forecasts
        /// </summary>
        /// <remarks>
        /// Use \&quot;recent\&quot; for the `weekDateId` path parameter to fetch all forecasts for +/- 26 weeks from the current date
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <returns>ApiResponse of ShortTermForecastListResponse</returns>
        ApiResponse<ShortTermForecastListResponse> GetWorkforcemanagementManagementunitWeekShorttermforecastsWithHttpInfo (string managementUnitId, string weekDateId);
        
        /// <summary>
        /// Get a work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to fetch</param>
        /// <returns>WorkPlan</returns>
        WorkPlan GetWorkforcemanagementManagementunitWorkplan (string managementUnitId, string workPlanId);

        /// <summary>
        /// Get a work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to fetch</param>
        /// <returns>ApiResponse of WorkPlan</returns>
        ApiResponse<WorkPlan> GetWorkforcemanagementManagementunitWorkplanWithHttpInfo (string managementUnitId, string workPlanId);
        
        /// <summary>
        /// Get work plans
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>WorkPlanListResponse</returns>
        WorkPlanListResponse GetWorkforcemanagementManagementunitWorkplans (string managementUnitId, List<string> expand = null);

        /// <summary>
        /// Get work plans
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>ApiResponse of WorkPlanListResponse</returns>
        ApiResponse<WorkPlanListResponse> GetWorkforcemanagementManagementunitWorkplansWithHttpInfo (string managementUnitId, List<string> expand = null);
        
        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>ManagementUnitListing</returns>
        ManagementUnitListing GetWorkforcemanagementManagementunits (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null);

        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>ApiResponse of ManagementUnitListing</returns>
        ApiResponse<ManagementUnitListing> GetWorkforcemanagementManagementunitsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null);
        
        /// <summary>
        /// Get management units across divisions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">The divisionIds to filter by. If omitted, will return all divisions (optional)</param>
        /// <returns>ManagementUnitListing</returns>
        ManagementUnitListing GetWorkforcemanagementManagementunitsDivisionviews (List<string> divisionId = null);

        /// <summary>
        /// Get management units across divisions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">The divisionIds to filter by. If omitted, will return all divisions (optional)</param>
        /// <returns>ApiResponse of ManagementUnitListing</returns>
        ApiResponse<ManagementUnitListing> GetWorkforcemanagementManagementunitsDivisionviewsWithHttpInfo (List<string> divisionId = null);
        
        /// <summary>
        /// Get a time off request for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>TimeOffRequestResponse</returns>
        TimeOffRequestResponse GetWorkforcemanagementTimeoffrequest (string timeOffRequestId);

        /// <summary>
        /// Get a time off request for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>ApiResponse of TimeOffRequestResponse</returns>
        ApiResponse<TimeOffRequestResponse> GetWorkforcemanagementTimeoffrequestWithHttpInfo (string timeOffRequestId);
        
        /// <summary>
        /// Get a list of time off requests for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>TimeOffRequestList</returns>
        TimeOffRequestList GetWorkforcemanagementTimeoffrequests (bool? recentlyReviewed = null);

        /// <summary>
        /// Get a list of time off requests for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>ApiResponse of TimeOffRequestList</returns>
        ApiResponse<TimeOffRequestList> GetWorkforcemanagementTimeoffrequestsWithHttpInfo (bool? recentlyReviewed = null);
        
        /// <summary>
        /// Update an activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ActivityCode</returns>
        ActivityCode PatchWorkforcemanagementManagementunitActivitycode (string muId, string acId, UpdateActivityCodeRequest body = null);

        /// <summary>
        /// Update an activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of ActivityCode</returns>
        ApiResponse<ActivityCode> PatchWorkforcemanagementManagementunitActivitycodeWithHttpInfo (string muId, string acId, UpdateActivityCodeRequest body = null);
        
        /// <summary>
        /// Marks a specific scheduling run as applied, allowing a new rescheduling run to be started
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <param name="body">body (optional)</param>
        /// <returns>RescheduleResult</returns>
        RescheduleResult PatchWorkforcemanagementManagementunitSchedulingRun (string managementUnitId, string runId, UpdateSchedulingRunRequest body = null);

        /// <summary>
        /// Marks a specific scheduling run as applied, allowing a new rescheduling run to be started
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of RescheduleResult</returns>
        ApiResponse<RescheduleResult> PatchWorkforcemanagementManagementunitSchedulingRunWithHttpInfo (string managementUnitId, string runId, UpdateSchedulingRunRequest body = null);
        
        /// <summary>
        /// Update a service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ServiceGoalGroup</returns>
        ServiceGoalGroup PatchWorkforcemanagementManagementunitServicegoalgroup (string managementUnitId, string serviceGoalGroupId, ServiceGoalGroup body = null);

        /// <summary>
        /// Update a service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of ServiceGoalGroup</returns>
        ApiResponse<ServiceGoalGroup> PatchWorkforcemanagementManagementunitServicegoalgroupWithHttpInfo (string managementUnitId, string serviceGoalGroupId, ServiceGoalGroup body = null);
        
        /// <summary>
        /// Patch the settings for the requested management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">config (optional)</param>
        /// <returns>ManagementUnitSettings</returns>
        ManagementUnitSettings PatchWorkforcemanagementManagementunitSettings (string muId, ManagementUnitSettings body = null);

        /// <summary>
        /// Patch the settings for the requested management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">config (optional)</param>
        /// <returns>ApiResponse of ManagementUnitSettings</returns>
        ApiResponse<ManagementUnitSettings> PatchWorkforcemanagementManagementunitSettingsWithHttpInfo (string muId, ManagementUnitSettings body = null);
        
        /// <summary>
        /// Update a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>TimeOffRequestResponse</returns>
        TimeOffRequestResponse PatchWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null);

        /// <summary>
        /// Update a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of TimeOffRequestResponse</returns>
        ApiResponse<TimeOffRequestResponse> PatchWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null);
        
        /// <summary>
        /// Update a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to update. Use partial uploads of user schedules if activity count in schedule is greater than 17500</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>AsyncWeekScheduleResponse</returns>
        AsyncWeekScheduleResponse PatchWorkforcemanagementManagementunitWeekSchedule (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, UpdateWeekScheduleRequest body = null);

        /// <summary>
        /// Update a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to update. Use partial uploads of user schedules if activity count in schedule is greater than 17500</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of AsyncWeekScheduleResponse</returns>
        ApiResponse<AsyncWeekScheduleResponse> PatchWorkforcemanagementManagementunitWeekScheduleWithHttpInfo (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, UpdateWeekScheduleRequest body = null);
        
        /// <summary>
        /// Update a work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>WorkPlan</returns>
        WorkPlan PatchWorkforcemanagementManagementunitWorkplan (string managementUnitId, string workPlanId, WorkPlan body = null);

        /// <summary>
        /// Update a work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WorkPlan</returns>
        ApiResponse<WorkPlan> PatchWorkforcemanagementManagementunitWorkplanWithHttpInfo (string managementUnitId, string workPlanId, WorkPlan body = null);
        
        /// <summary>
        /// Update a time off request for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>TimeOffRequestResponse</returns>
        TimeOffRequestResponse PatchWorkforcemanagementTimeoffrequest (string timeOffRequestId, AgentTimeOffRequestPatch body = null);

        /// <summary>
        /// Update a time off request for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of TimeOffRequestResponse</returns>
        ApiResponse<TimeOffRequestResponse> PatchWorkforcemanagementTimeoffrequestWithHttpInfo (string timeOffRequestId, AgentTimeOffRequestPatch body = null);
        
        /// <summary>
        /// Request a historical adherence report for users across management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>WfmHistoricalAdherenceResponse</returns>
        WfmHistoricalAdherenceResponse PostWorkforcemanagementAdherenceHistorical (WfmHistoricalAdherenceQueryForUsers body = null);

        /// <summary>
        /// Request a historical adherence report for users across management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WfmHistoricalAdherenceResponse</returns>
        ApiResponse<WfmHistoricalAdherenceResponse> PostWorkforcemanagementAdherenceHistoricalWithHttpInfo (WfmHistoricalAdherenceQueryForUsers body = null);
        
        /// <summary>
        /// Create a new activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ActivityCode</returns>
        ActivityCode PostWorkforcemanagementManagementunitActivitycodes (string muId, CreateActivityCodeRequest body = null);

        /// <summary>
        /// Create a new activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of ActivityCode</returns>
        ApiResponse<ActivityCode> PostWorkforcemanagementManagementunitActivitycodesWithHttpInfo (string muId, CreateActivityCodeRequest body = null);
        
        /// <summary>
        /// Request a historical adherence report
        /// </summary>
        /// <remarks>
        /// The maximum supported range for historical adherence queries is 31 days, or 7 days with includeExceptions = true
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>WfmHistoricalAdherenceResponse</returns>
        WfmHistoricalAdherenceResponse PostWorkforcemanagementManagementunitHistoricaladherencequery (string muId, WfmHistoricalAdherenceQuery body = null);

        /// <summary>
        /// Request a historical adherence report
        /// </summary>
        /// <remarks>
        /// The maximum supported range for historical adherence queries is 31 days, or 7 days with includeExceptions = true
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WfmHistoricalAdherenceResponse</returns>
        ApiResponse<WfmHistoricalAdherenceResponse> PostWorkforcemanagementManagementunitHistoricaladherencequeryWithHttpInfo (string muId, WfmHistoricalAdherenceQuery body = null);
        
        /// <summary>
        /// Get intraday data for the given date for the requested queueIds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>IntradayResponse</returns>
        IntradayResponse PostWorkforcemanagementManagementunitIntraday (string muId, IntradayQueryDataCommand body = null);

        /// <summary>
        /// Get intraday data for the given date for the requested queueIds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of IntradayResponse</returns>
        ApiResponse<IntradayResponse> PostWorkforcemanagementManagementunitIntradayWithHttpInfo (string muId, IntradayQueryDataCommand body = null);
        
        /// <summary>
        /// Query published schedules for given given time range for set of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>UserScheduleContainer</returns>
        UserScheduleContainer PostWorkforcemanagementManagementunitSchedulesSearch (string muId, UserListScheduleRequestBody body = null);

        /// <summary>
        /// Query published schedules for given given time range for set of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of UserScheduleContainer</returns>
        ApiResponse<UserScheduleContainer> PostWorkforcemanagementManagementunitSchedulesSearchWithHttpInfo (string muId, UserListScheduleRequestBody body = null);
        
        /// <summary>
        /// Create a new service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ServiceGoalGroup</returns>
        ServiceGoalGroup PostWorkforcemanagementManagementunitServicegoalgroups (string managementUnitId, CreateServiceGoalGroupRequest body = null);

        /// <summary>
        /// Create a new service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of ServiceGoalGroup</returns>
        ApiResponse<ServiceGoalGroup> PostWorkforcemanagementManagementunitServicegoalgroupsWithHttpInfo (string managementUnitId, CreateServiceGoalGroupRequest body = null);
        
        /// <summary>
        /// Create a new time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>TimeOffRequestList</returns>
        TimeOffRequestList PostWorkforcemanagementManagementunitTimeoffrequests (string muId, CreateAdminTimeOffRequest body = null);

        /// <summary>
        /// Create a new time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of TimeOffRequestList</returns>
        ApiResponse<TimeOffRequestList> PostWorkforcemanagementManagementunitTimeoffrequestsWithHttpInfo (string muId, CreateAdminTimeOffRequest body = null);
        
        /// <summary>
        /// Gets a list of time off requests from lookup ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>TimeOffRequestEntityList</returns>
        TimeOffRequestEntityList PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails (string muId, TimeOffRequestLookupList body = null);

        /// <summary>
        /// Gets a list of time off requests from lookup ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of TimeOffRequestEntityList</returns>
        ApiResponse<TimeOffRequestEntityList> PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetailsWithHttpInfo (string muId, TimeOffRequestLookupList body = null);
        
        /// <summary>
        /// Gets the lookup ids to fetch the specified set of requests
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>TimeOffRequestLookupList</returns>
        TimeOffRequestLookupList PostWorkforcemanagementManagementunitTimeoffrequestsQuery (string muId, TimeOffRequestQueryBody body = null);

        /// <summary>
        /// Gets the lookup ids to fetch the specified set of requests
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of TimeOffRequestLookupList</returns>
        ApiResponse<TimeOffRequestLookupList> PostWorkforcemanagementManagementunitTimeoffrequestsQueryWithHttpInfo (string muId, TimeOffRequestQueryBody body = null);
        
        /// <summary>
        /// Copy a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to copy from</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>AsyncWeekScheduleResponse</returns>
        AsyncWeekScheduleResponse PostWorkforcemanagementManagementunitWeekScheduleCopy (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, CopyWeekScheduleRequest body = null);

        /// <summary>
        /// Copy a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to copy from</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of AsyncWeekScheduleResponse</returns>
        ApiResponse<AsyncWeekScheduleResponse> PostWorkforcemanagementManagementunitWeekScheduleCopyWithHttpInfo (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, CopyWeekScheduleRequest body = null);
        
        /// <summary>
        /// Start a scheduling run to compute the reschedule. When the scheduling run finishes, a client can get the reschedule changes and then the client can apply them to the schedule, save the schedule, and mark the scheduling run as applied
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to re-optimize</param>
        /// <param name="body">body (optional)</param>
        /// <returns>AsyncWeekScheduleResponse</returns>
        AsyncWeekScheduleResponse PostWorkforcemanagementManagementunitWeekScheduleReschedule (string managementUnitId, string weekId, string scheduleId, RescheduleRequest body = null);

        /// <summary>
        /// Start a scheduling run to compute the reschedule. When the scheduling run finishes, a client can get the reschedule changes and then the client can apply them to the schedule, save the schedule, and mark the scheduling run as applied
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to re-optimize</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of AsyncWeekScheduleResponse</returns>
        ApiResponse<AsyncWeekScheduleResponse> PostWorkforcemanagementManagementunitWeekScheduleRescheduleWithHttpInfo (string managementUnitId, string weekId, string scheduleId, RescheduleRequest body = null);
        
        /// <summary>
        /// Add a schedule for a week in management unit using imported data. Use partial uploads of user schedules if activity count in schedule is greater than 17500
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>AsyncWeekScheduleResponse</returns>
        AsyncWeekScheduleResponse PostWorkforcemanagementManagementunitWeekSchedules (string managementUnitId, string weekId, bool? forceAsync = null, bool? forceDownloadService = null, ImportWeekScheduleRequest body = null);

        /// <summary>
        /// Add a schedule for a week in management unit using imported data. Use partial uploads of user schedules if activity count in schedule is greater than 17500
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of AsyncWeekScheduleResponse</returns>
        ApiResponse<AsyncWeekScheduleResponse> PostWorkforcemanagementManagementunitWeekSchedulesWithHttpInfo (string managementUnitId, string weekId, bool? forceAsync = null, bool? forceDownloadService = null, ImportWeekScheduleRequest body = null);
        
        /// <summary>
        /// Generate a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>GenerateWeekScheduleResponse</returns>
        GenerateWeekScheduleResponse PostWorkforcemanagementManagementunitWeekSchedulesGenerate (string managementUnitId, string weekId, GenerateWeekScheduleRequest body = null);

        /// <summary>
        /// Generate a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of GenerateWeekScheduleResponse</returns>
        ApiResponse<GenerateWeekScheduleResponse> PostWorkforcemanagementManagementunitWeekSchedulesGenerateWithHttpInfo (string managementUnitId, string weekId, GenerateWeekScheduleRequest body = null);
        
        /// <summary>
        /// Partial upload of user schedules where activity count is greater than 17500
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>PartialUploadResponse</returns>
        PartialUploadResponse PostWorkforcemanagementManagementunitWeekSchedulesPartialupload (string managementUnitId, string weekId, UserSchedulesPartialUploadRequest body = null);

        /// <summary>
        /// Partial upload of user schedules where activity count is greater than 17500
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of PartialUploadResponse</returns>
        ApiResponse<PartialUploadResponse> PostWorkforcemanagementManagementunitWeekSchedulesPartialuploadWithHttpInfo (string managementUnitId, string weekId, UserSchedulesPartialUploadRequest body = null);
        
        /// <summary>
        /// Copy a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast to copy</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>ShortTermForecastResponse</returns>
        ShortTermForecastResponse PostWorkforcemanagementManagementunitWeekShorttermforecastCopy (string managementUnitId, string weekDateId, string forecastId, CopyShortTermForecastRequest body, bool? forceAsync = null);

        /// <summary>
        /// Copy a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast to copy</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>ApiResponse of ShortTermForecastResponse</returns>
        ApiResponse<ShortTermForecastResponse> PostWorkforcemanagementManagementunitWeekShorttermforecastCopyWithHttpInfo (string managementUnitId, string weekDateId, string forecastId, CopyShortTermForecastRequest body, bool? forceAsync = null);
        
        /// <summary>
        /// Import a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>ShortTermForecastResponse</returns>
        ShortTermForecastResponse PostWorkforcemanagementManagementunitWeekShorttermforecasts (string managementUnitId, string weekDateId, ImportShortTermForecastRequest body, bool? forceAsync = null);

        /// <summary>
        /// Import a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>ApiResponse of ShortTermForecastResponse</returns>
        ApiResponse<ShortTermForecastResponse> PostWorkforcemanagementManagementunitWeekShorttermforecastsWithHttpInfo (string managementUnitId, string weekDateId, ImportShortTermForecastRequest body, bool? forceAsync = null);
        
        /// <summary>
        /// Generate a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body"></param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>GenerateShortTermForecastResponse</returns>
        GenerateShortTermForecastResponse PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate (string managementUnitId, string weekDateId, GenerateShortTermForecastRequest body, bool? forceAsync = null);

        /// <summary>
        /// Generate a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body"></param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>ApiResponse of GenerateShortTermForecastResponse</returns>
        ApiResponse<GenerateShortTermForecastResponse> PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerateWithHttpInfo (string managementUnitId, string weekDateId, GenerateShortTermForecastRequest body, bool? forceAsync = null);
        
        /// <summary>
        /// Import a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <returns>PartialUploadResponse</returns>
        PartialUploadResponse PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload (string managementUnitId, string weekDateId, RouteGroupList body);

        /// <summary>
        /// Import a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <returns>ApiResponse of PartialUploadResponse</returns>
        ApiResponse<PartialUploadResponse> PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialuploadWithHttpInfo (string managementUnitId, string weekDateId, RouteGroupList body);
        
        /// <summary>
        /// Create a copy of work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to create a copy</param>
        /// <param name="body">body (optional)</param>
        /// <returns>WorkPlan</returns>
        WorkPlan PostWorkforcemanagementManagementunitWorkplanCopy (string managementUnitId, string workPlanId, CopyWorkPlan body = null);

        /// <summary>
        /// Create a copy of work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to create a copy</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WorkPlan</returns>
        ApiResponse<WorkPlan> PostWorkforcemanagementManagementunitWorkplanCopyWithHttpInfo (string managementUnitId, string workPlanId, CopyWorkPlan body = null);
        
        /// <summary>
        /// Create a new work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>WorkPlan</returns>
        WorkPlan PostWorkforcemanagementManagementunitWorkplans (string managementUnitId, CreateWorkPlan body = null);

        /// <summary>
        /// Create a new work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WorkPlan</returns>
        ApiResponse<WorkPlan> PostWorkforcemanagementManagementunitWorkplansWithHttpInfo (string managementUnitId, CreateWorkPlan body = null);
        
        /// <summary>
        /// Add a management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ManagementUnit</returns>
        ManagementUnit PostWorkforcemanagementManagementunits (CreateManagementUnitApiRequest body = null);

        /// <summary>
        /// Add a management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of ManagementUnit</returns>
        ApiResponse<ManagementUnit> PostWorkforcemanagementManagementunitsWithHttpInfo (CreateManagementUnitApiRequest body = null);
        
        /// <summary>
        /// Get published schedule for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>UserScheduleContainer</returns>
        UserScheduleContainer PostWorkforcemanagementSchedules (CurrentUserScheduleRequestBody body = null);

        /// <summary>
        /// Get published schedule for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of UserScheduleContainer</returns>
        ApiResponse<UserScheduleContainer> PostWorkforcemanagementSchedulesWithHttpInfo (CurrentUserScheduleRequestBody body = null);
        
        /// <summary>
        /// Create a time off request for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>TimeOffRequestResponse</returns>
        TimeOffRequestResponse PostWorkforcemanagementTimeoffrequests (CreateAgentTimeOffRequest body = null);

        /// <summary>
        /// Create a time off request for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of TimeOffRequestResponse</returns>
        ApiResponse<TimeOffRequestResponse> PostWorkforcemanagementTimeoffrequestsWithHttpInfo (CreateAgentTimeOffRequest body = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorkforcemanagementManagementunitAsync (string muId);

        /// <summary>
        /// Delete management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkforcemanagementManagementunitAsyncWithHttpInfo (string muId);
        
        /// <summary>
        /// Deletes an activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorkforcemanagementManagementunitActivitycodeAsync (string muId, string acId);

        /// <summary>
        /// Deletes an activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkforcemanagementManagementunitActivitycodeAsyncWithHttpInfo (string muId, string acId);
        
        /// <summary>
        /// Cancel a schedule run
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorkforcemanagementManagementunitSchedulingRunAsync (string managementUnitId, string runId);

        /// <summary>
        /// Cancel a schedule run
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkforcemanagementManagementunitSchedulingRunAsyncWithHttpInfo (string managementUnitId, string runId);
        
        /// <summary>
        /// Delete a service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorkforcemanagementManagementunitServicegoalgroupAsync (string managementUnitId, string serviceGoalGroupId);

        /// <summary>
        /// Delete a service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkforcemanagementManagementunitServicegoalgroupAsyncWithHttpInfo (string managementUnitId, string serviceGoalGroupId);
        
        /// <summary>
        /// Delete a schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of theschedule to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorkforcemanagementManagementunitWeekScheduleAsync (string managementUnitId, string weekId, string scheduleId);

        /// <summary>
        /// Delete a schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of theschedule to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkforcemanagementManagementunitWeekScheduleAsyncWithHttpInfo (string managementUnitId, string weekId, string scheduleId);
        
        /// <summary>
        /// Delete a short term forecast
        /// </summary>
        /// <remarks>
        /// Must not be tied to any schedules
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorkforcemanagementManagementunitWeekShorttermforecastAsync (string managementUnitId, string weekDateId, string forecastId);

        /// <summary>
        /// Delete a short term forecast
        /// </summary>
        /// <remarks>
        /// Must not be tied to any schedules
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkforcemanagementManagementunitWeekShorttermforecastAsyncWithHttpInfo (string managementUnitId, string weekDateId, string forecastId);
        
        /// <summary>
        /// Delete a work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorkforcemanagementManagementunitWorkplanAsync (string managementUnitId, string workPlanId);

        /// <summary>
        /// Delete a work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkforcemanagementManagementunitWorkplanAsyncWithHttpInfo (string managementUnitId, string workPlanId);
        
        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>Task of List&lt;UserScheduleAdherence&gt;</returns>
        System.Threading.Tasks.Task<List<UserScheduleAdherence>> GetWorkforcemanagementAdherenceAsync (List<string> userId);

        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>Task of ApiResponse (List&lt;UserScheduleAdherence&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<UserScheduleAdherence>>> GetWorkforcemanagementAdherenceAsyncWithHttpInfo (List<string> userId);
        
        /// <summary>
        /// Get management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>Task of ManagementUnit</returns>
        System.Threading.Tasks.Task<ManagementUnit> GetWorkforcemanagementManagementunitAsync (string muId, string expand = null);

        /// <summary>
        /// Get management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>Task of ApiResponse (ManagementUnit)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagementUnit>> GetWorkforcemanagementManagementunitAsyncWithHttpInfo (string muId, string expand = null);
        
        /// <summary>
        /// Get an activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to fetch</param>
        /// <returns>Task of ActivityCode</returns>
        System.Threading.Tasks.Task<ActivityCode> GetWorkforcemanagementManagementunitActivitycodeAsync (string muId, string acId);

        /// <summary>
        /// Get an activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to fetch</param>
        /// <returns>Task of ApiResponse (ActivityCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActivityCode>> GetWorkforcemanagementManagementunitActivitycodeAsyncWithHttpInfo (string muId, string acId);
        
        /// <summary>
        /// Get activity codes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ActivityCodeContainer</returns>
        System.Threading.Tasks.Task<ActivityCodeContainer> GetWorkforcemanagementManagementunitActivitycodesAsync (string muId);

        /// <summary>
        /// Get activity codes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse (ActivityCodeContainer)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActivityCodeContainer>> GetWorkforcemanagementManagementunitActivitycodesAsyncWithHttpInfo (string muId);
        
        /// <summary>
        /// Get data for agent in the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The id of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="agentId">The agent id</param>
        /// <returns>Task of WfmAgent</returns>
        System.Threading.Tasks.Task<WfmAgent> GetWorkforcemanagementManagementunitAgentAsync (string managementUnitId, string agentId);

        /// <summary>
        /// Get data for agent in the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The id of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="agentId">The agent id</param>
        /// <returns>Task of ApiResponse (WfmAgent)</returns>
        System.Threading.Tasks.Task<ApiResponse<WfmAgent>> GetWorkforcemanagementManagementunitAgentAsyncWithHttpInfo (string managementUnitId, string agentId);
        
        /// <summary>
        /// Get intraday queues for the given date
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="date">yyyy-MM-dd date string interpreted in the configured management unit time zone</param>
        /// <returns>Task of WfmIntradayQueueListing</returns>
        System.Threading.Tasks.Task<WfmIntradayQueueListing> GetWorkforcemanagementManagementunitIntradayQueuesAsync (string muId, string date);

        /// <summary>
        /// Get intraday queues for the given date
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="date">yyyy-MM-dd date string interpreted in the configured management unit time zone</param>
        /// <returns>Task of ApiResponse (WfmIntradayQueueListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WfmIntradayQueueListing>> GetWorkforcemanagementManagementunitIntradayQueuesAsyncWithHttpInfo (string muId, string date);
        
        /// <summary>
        /// Gets the status for a specific scheduling run
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>Task of SchedulingRunResponse</returns>
        System.Threading.Tasks.Task<SchedulingRunResponse> GetWorkforcemanagementManagementunitSchedulingRunAsync (string managementUnitId, string runId);

        /// <summary>
        /// Gets the status for a specific scheduling run
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>Task of ApiResponse (SchedulingRunResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SchedulingRunResponse>> GetWorkforcemanagementManagementunitSchedulingRunAsyncWithHttpInfo (string managementUnitId, string runId);
        
        /// <summary>
        /// Gets the result of a specific scheduling run
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>Task of RescheduleResult</returns>
        System.Threading.Tasks.Task<RescheduleResult> GetWorkforcemanagementManagementunitSchedulingRunResultAsync (string managementUnitId, string runId);

        /// <summary>
        /// Gets the result of a specific scheduling run
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>Task of ApiResponse (RescheduleResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<RescheduleResult>> GetWorkforcemanagementManagementunitSchedulingRunResultAsyncWithHttpInfo (string managementUnitId, string runId);
        
        /// <summary>
        /// Get the status of all the ongoing schedule runs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <returns>Task of SchedulingRunListResponse</returns>
        System.Threading.Tasks.Task<SchedulingRunListResponse> GetWorkforcemanagementManagementunitSchedulingRunsAsync (string managementUnitId);

        /// <summary>
        /// Get the status of all the ongoing schedule runs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <returns>Task of ApiResponse (SchedulingRunListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SchedulingRunListResponse>> GetWorkforcemanagementManagementunitSchedulingRunsAsyncWithHttpInfo (string managementUnitId);
        
        /// <summary>
        /// Get a service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to fetch</param>
        /// <returns>Task of ServiceGoalGroup</returns>
        System.Threading.Tasks.Task<ServiceGoalGroup> GetWorkforcemanagementManagementunitServicegoalgroupAsync (string managementUnitId, string serviceGoalGroupId);

        /// <summary>
        /// Get a service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to fetch</param>
        /// <returns>Task of ApiResponse (ServiceGoalGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServiceGoalGroup>> GetWorkforcemanagementManagementunitServicegoalgroupAsyncWithHttpInfo (string managementUnitId, string serviceGoalGroupId);
        
        /// <summary>
        /// Get service goal groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ServiceGoalGroupList</returns>
        System.Threading.Tasks.Task<ServiceGoalGroupList> GetWorkforcemanagementManagementunitServicegoalgroupsAsync (string managementUnitId);

        /// <summary>
        /// Get service goal groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse (ServiceGoalGroupList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServiceGoalGroupList>> GetWorkforcemanagementManagementunitServicegoalgroupsAsyncWithHttpInfo (string managementUnitId);
        
        /// <summary>
        /// Get the settings for the requested management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ManagementUnitSettings</returns>
        System.Threading.Tasks.Task<ManagementUnitSettings> GetWorkforcemanagementManagementunitSettingsAsync (string muId);

        /// <summary>
        /// Get the settings for the requested management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse (ManagementUnitSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagementUnitSettings>> GetWorkforcemanagementManagementunitSettingsAsyncWithHttpInfo (string muId);
        
        /// <summary>
        /// Get a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of TimeOffRequestResponse</returns>
        System.Threading.Tasks.Task<TimeOffRequestResponse> GetWorkforcemanagementManagementunitUserTimeoffrequestAsync (string muId, string userId, string timeOffRequestId);

        /// <summary>
        /// Get a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of ApiResponse (TimeOffRequestResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestResponse>> GetWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo (string muId, string userId, string timeOffRequestId);
        
        /// <summary>
        /// Get a list of time off requests for a given user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of TimeOffRequestList</returns>
        System.Threading.Tasks.Task<TimeOffRequestList> GetWorkforcemanagementManagementunitUserTimeoffrequestsAsync (string muId, string userId, bool? recentlyReviewed = null);

        /// <summary>
        /// Get a list of time off requests for a given user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestList>> GetWorkforcemanagementManagementunitUserTimeoffrequestsAsyncWithHttpInfo (string muId, string userId, bool? recentlyReviewed = null);
        
        /// <summary>
        /// Get users in the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of WfmUserEntityListing</returns>
        System.Threading.Tasks.Task<WfmUserEntityListing> GetWorkforcemanagementManagementunitUsersAsync (string muId);

        /// <summary>
        /// Get users in the management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse (WfmUserEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WfmUserEntityListing>> GetWorkforcemanagementManagementunitUsersAsyncWithHttpInfo (string muId);
        
        /// <summary>
        /// Get a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>Task of WeekScheduleResponse</returns>
        System.Threading.Tasks.Task<WeekScheduleResponse> GetWorkforcemanagementManagementunitWeekScheduleAsync (string managementUnitId, string weekId, string scheduleId, string expand = null, bool? forceDownloadService = null);

        /// <summary>
        /// Get a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ApiResponse (WeekScheduleResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WeekScheduleResponse>> GetWorkforcemanagementManagementunitWeekScheduleAsyncWithHttpInfo (string managementUnitId, string weekId, string scheduleId, string expand = null, bool? forceDownloadService = null);
        
        /// <summary>
        /// Get week schedule generation results
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch generation results</param>
        /// <returns>Task of WeekScheduleGenerationResult</returns>
        System.Threading.Tasks.Task<WeekScheduleGenerationResult> GetWorkforcemanagementManagementunitWeekScheduleGenerationresultsAsync (string managementUnitId, string weekId, string scheduleId);

        /// <summary>
        /// Get week schedule generation results
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch generation results</param>
        /// <returns>Task of ApiResponse (WeekScheduleGenerationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<WeekScheduleGenerationResult>> GetWorkforcemanagementManagementunitWeekScheduleGenerationresultsAsyncWithHttpInfo (string managementUnitId, string weekId, string scheduleId);
        
        /// <summary>
        /// Get the list of schedules in a week in management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <returns>Task of WeekScheduleListResponse</returns>
        System.Threading.Tasks.Task<WeekScheduleListResponse> GetWorkforcemanagementManagementunitWeekSchedulesAsync (string managementUnitId, string weekId);

        /// <summary>
        /// Get the list of schedules in a week in management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <returns>Task of ApiResponse (WeekScheduleListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WeekScheduleListResponse>> GetWorkforcemanagementManagementunitWeekSchedulesAsyncWithHttpInfo (string managementUnitId, string weekId);
        
        /// <summary>
        /// Get the final result of a short term forecast calculation with modifications applied
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ForecastResultResponse</returns>
        System.Threading.Tasks.Task<ForecastResultResponse> GetWorkforcemanagementManagementunitWeekShorttermforecastFinalAsync (string managementUnitId, string weekDateId, string forecastId, bool? forceDownloadService = null);

        /// <summary>
        /// Get the final result of a short term forecast calculation with modifications applied
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ApiResponse (ForecastResultResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ForecastResultResponse>> GetWorkforcemanagementManagementunitWeekShorttermforecastFinalAsyncWithHttpInfo (string managementUnitId, string weekDateId, string forecastId, bool? forceDownloadService = null);
        
        /// <summary>
        /// Get short term forecasts
        /// </summary>
        /// <remarks>
        /// Use \&quot;recent\&quot; for the `weekDateId` path parameter to fetch all forecasts for +/- 26 weeks from the current date
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <returns>Task of ShortTermForecastListResponse</returns>
        System.Threading.Tasks.Task<ShortTermForecastListResponse> GetWorkforcemanagementManagementunitWeekShorttermforecastsAsync (string managementUnitId, string weekDateId);

        /// <summary>
        /// Get short term forecasts
        /// </summary>
        /// <remarks>
        /// Use \&quot;recent\&quot; for the `weekDateId` path parameter to fetch all forecasts for +/- 26 weeks from the current date
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <returns>Task of ApiResponse (ShortTermForecastListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShortTermForecastListResponse>> GetWorkforcemanagementManagementunitWeekShorttermforecastsAsyncWithHttpInfo (string managementUnitId, string weekDateId);
        
        /// <summary>
        /// Get a work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to fetch</param>
        /// <returns>Task of WorkPlan</returns>
        System.Threading.Tasks.Task<WorkPlan> GetWorkforcemanagementManagementunitWorkplanAsync (string managementUnitId, string workPlanId);

        /// <summary>
        /// Get a work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to fetch</param>
        /// <returns>Task of ApiResponse (WorkPlan)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkPlan>> GetWorkforcemanagementManagementunitWorkplanAsyncWithHttpInfo (string managementUnitId, string workPlanId);
        
        /// <summary>
        /// Get work plans
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>Task of WorkPlanListResponse</returns>
        System.Threading.Tasks.Task<WorkPlanListResponse> GetWorkforcemanagementManagementunitWorkplansAsync (string managementUnitId, List<string> expand = null);

        /// <summary>
        /// Get work plans
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>Task of ApiResponse (WorkPlanListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkPlanListResponse>> GetWorkforcemanagementManagementunitWorkplansAsyncWithHttpInfo (string managementUnitId, List<string> expand = null);
        
        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>Task of ManagementUnitListing</returns>
        System.Threading.Tasks.Task<ManagementUnitListing> GetWorkforcemanagementManagementunitsAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null);

        /// <summary>
        /// Get management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>Task of ApiResponse (ManagementUnitListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagementUnitListing>> GetWorkforcemanagementManagementunitsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null);
        
        /// <summary>
        /// Get management units across divisions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">The divisionIds to filter by. If omitted, will return all divisions (optional)</param>
        /// <returns>Task of ManagementUnitListing</returns>
        System.Threading.Tasks.Task<ManagementUnitListing> GetWorkforcemanagementManagementunitsDivisionviewsAsync (List<string> divisionId = null);

        /// <summary>
        /// Get management units across divisions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">The divisionIds to filter by. If omitted, will return all divisions (optional)</param>
        /// <returns>Task of ApiResponse (ManagementUnitListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagementUnitListing>> GetWorkforcemanagementManagementunitsDivisionviewsAsyncWithHttpInfo (List<string> divisionId = null);
        
        /// <summary>
        /// Get a time off request for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of TimeOffRequestResponse</returns>
        System.Threading.Tasks.Task<TimeOffRequestResponse> GetWorkforcemanagementTimeoffrequestAsync (string timeOffRequestId);

        /// <summary>
        /// Get a time off request for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of ApiResponse (TimeOffRequestResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestResponse>> GetWorkforcemanagementTimeoffrequestAsyncWithHttpInfo (string timeOffRequestId);
        
        /// <summary>
        /// Get a list of time off requests for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of TimeOffRequestList</returns>
        System.Threading.Tasks.Task<TimeOffRequestList> GetWorkforcemanagementTimeoffrequestsAsync (bool? recentlyReviewed = null);

        /// <summary>
        /// Get a list of time off requests for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestList>> GetWorkforcemanagementTimeoffrequestsAsyncWithHttpInfo (bool? recentlyReviewed = null);
        
        /// <summary>
        /// Update an activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ActivityCode</returns>
        System.Threading.Tasks.Task<ActivityCode> PatchWorkforcemanagementManagementunitActivitycodeAsync (string muId, string acId, UpdateActivityCodeRequest body = null);

        /// <summary>
        /// Update an activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (ActivityCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActivityCode>> PatchWorkforcemanagementManagementunitActivitycodeAsyncWithHttpInfo (string muId, string acId, UpdateActivityCodeRequest body = null);
        
        /// <summary>
        /// Marks a specific scheduling run as applied, allowing a new rescheduling run to be started
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of RescheduleResult</returns>
        System.Threading.Tasks.Task<RescheduleResult> PatchWorkforcemanagementManagementunitSchedulingRunAsync (string managementUnitId, string runId, UpdateSchedulingRunRequest body = null);

        /// <summary>
        /// Marks a specific scheduling run as applied, allowing a new rescheduling run to be started
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (RescheduleResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<RescheduleResult>> PatchWorkforcemanagementManagementunitSchedulingRunAsyncWithHttpInfo (string managementUnitId, string runId, UpdateSchedulingRunRequest body = null);
        
        /// <summary>
        /// Update a service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ServiceGoalGroup</returns>
        System.Threading.Tasks.Task<ServiceGoalGroup> PatchWorkforcemanagementManagementunitServicegoalgroupAsync (string managementUnitId, string serviceGoalGroupId, ServiceGoalGroup body = null);

        /// <summary>
        /// Update a service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (ServiceGoalGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServiceGoalGroup>> PatchWorkforcemanagementManagementunitServicegoalgroupAsyncWithHttpInfo (string managementUnitId, string serviceGoalGroupId, ServiceGoalGroup body = null);
        
        /// <summary>
        /// Patch the settings for the requested management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">config (optional)</param>
        /// <returns>Task of ManagementUnitSettings</returns>
        System.Threading.Tasks.Task<ManagementUnitSettings> PatchWorkforcemanagementManagementunitSettingsAsync (string muId, ManagementUnitSettings body = null);

        /// <summary>
        /// Patch the settings for the requested management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">config (optional)</param>
        /// <returns>Task of ApiResponse (ManagementUnitSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagementUnitSettings>> PatchWorkforcemanagementManagementunitSettingsAsyncWithHttpInfo (string muId, ManagementUnitSettings body = null);
        
        /// <summary>
        /// Update a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of TimeOffRequestResponse</returns>
        System.Threading.Tasks.Task<TimeOffRequestResponse> PatchWorkforcemanagementManagementunitUserTimeoffrequestAsync (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null);

        /// <summary>
        /// Update a time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestResponse>> PatchWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null);
        
        /// <summary>
        /// Update a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to update. Use partial uploads of user schedules if activity count in schedule is greater than 17500</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of AsyncWeekScheduleResponse</returns>
        System.Threading.Tasks.Task<AsyncWeekScheduleResponse> PatchWorkforcemanagementManagementunitWeekScheduleAsync (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, UpdateWeekScheduleRequest body = null);

        /// <summary>
        /// Update a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to update. Use partial uploads of user schedules if activity count in schedule is greater than 17500</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (AsyncWeekScheduleResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncWeekScheduleResponse>> PatchWorkforcemanagementManagementunitWeekScheduleAsyncWithHttpInfo (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, UpdateWeekScheduleRequest body = null);
        
        /// <summary>
        /// Update a work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WorkPlan</returns>
        System.Threading.Tasks.Task<WorkPlan> PatchWorkforcemanagementManagementunitWorkplanAsync (string managementUnitId, string workPlanId, WorkPlan body = null);

        /// <summary>
        /// Update a work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WorkPlan)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkPlan>> PatchWorkforcemanagementManagementunitWorkplanAsyncWithHttpInfo (string managementUnitId, string workPlanId, WorkPlan body = null);
        
        /// <summary>
        /// Update a time off request for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of TimeOffRequestResponse</returns>
        System.Threading.Tasks.Task<TimeOffRequestResponse> PatchWorkforcemanagementTimeoffrequestAsync (string timeOffRequestId, AgentTimeOffRequestPatch body = null);

        /// <summary>
        /// Update a time off request for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestResponse>> PatchWorkforcemanagementTimeoffrequestAsyncWithHttpInfo (string timeOffRequestId, AgentTimeOffRequestPatch body = null);
        
        /// <summary>
        /// Request a historical adherence report for users across management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WfmHistoricalAdherenceResponse</returns>
        System.Threading.Tasks.Task<WfmHistoricalAdherenceResponse> PostWorkforcemanagementAdherenceHistoricalAsync (WfmHistoricalAdherenceQueryForUsers body = null);

        /// <summary>
        /// Request a historical adherence report for users across management units
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WfmHistoricalAdherenceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WfmHistoricalAdherenceResponse>> PostWorkforcemanagementAdherenceHistoricalAsyncWithHttpInfo (WfmHistoricalAdherenceQueryForUsers body = null);
        
        /// <summary>
        /// Create a new activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ActivityCode</returns>
        System.Threading.Tasks.Task<ActivityCode> PostWorkforcemanagementManagementunitActivitycodesAsync (string muId, CreateActivityCodeRequest body = null);

        /// <summary>
        /// Create a new activity code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (ActivityCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActivityCode>> PostWorkforcemanagementManagementunitActivitycodesAsyncWithHttpInfo (string muId, CreateActivityCodeRequest body = null);
        
        /// <summary>
        /// Request a historical adherence report
        /// </summary>
        /// <remarks>
        /// The maximum supported range for historical adherence queries is 31 days, or 7 days with includeExceptions = true
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WfmHistoricalAdherenceResponse</returns>
        System.Threading.Tasks.Task<WfmHistoricalAdherenceResponse> PostWorkforcemanagementManagementunitHistoricaladherencequeryAsync (string muId, WfmHistoricalAdherenceQuery body = null);

        /// <summary>
        /// Request a historical adherence report
        /// </summary>
        /// <remarks>
        /// The maximum supported range for historical adherence queries is 31 days, or 7 days with includeExceptions = true
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WfmHistoricalAdherenceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WfmHistoricalAdherenceResponse>> PostWorkforcemanagementManagementunitHistoricaladherencequeryAsyncWithHttpInfo (string muId, WfmHistoricalAdherenceQuery body = null);
        
        /// <summary>
        /// Get intraday data for the given date for the requested queueIds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of IntradayResponse</returns>
        System.Threading.Tasks.Task<IntradayResponse> PostWorkforcemanagementManagementunitIntradayAsync (string muId, IntradayQueryDataCommand body = null);

        /// <summary>
        /// Get intraday data for the given date for the requested queueIds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (IntradayResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntradayResponse>> PostWorkforcemanagementManagementunitIntradayAsyncWithHttpInfo (string muId, IntradayQueryDataCommand body = null);
        
        /// <summary>
        /// Query published schedules for given given time range for set of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of UserScheduleContainer</returns>
        System.Threading.Tasks.Task<UserScheduleContainer> PostWorkforcemanagementManagementunitSchedulesSearchAsync (string muId, UserListScheduleRequestBody body = null);

        /// <summary>
        /// Query published schedules for given given time range for set of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (UserScheduleContainer)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserScheduleContainer>> PostWorkforcemanagementManagementunitSchedulesSearchAsyncWithHttpInfo (string muId, UserListScheduleRequestBody body = null);
        
        /// <summary>
        /// Create a new service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ServiceGoalGroup</returns>
        System.Threading.Tasks.Task<ServiceGoalGroup> PostWorkforcemanagementManagementunitServicegoalgroupsAsync (string managementUnitId, CreateServiceGoalGroupRequest body = null);

        /// <summary>
        /// Create a new service goal group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (ServiceGoalGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServiceGoalGroup>> PostWorkforcemanagementManagementunitServicegoalgroupsAsyncWithHttpInfo (string managementUnitId, CreateServiceGoalGroupRequest body = null);
        
        /// <summary>
        /// Create a new time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of TimeOffRequestList</returns>
        System.Threading.Tasks.Task<TimeOffRequestList> PostWorkforcemanagementManagementunitTimeoffrequestsAsync (string muId, CreateAdminTimeOffRequest body = null);

        /// <summary>
        /// Create a new time off request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestList>> PostWorkforcemanagementManagementunitTimeoffrequestsAsyncWithHttpInfo (string muId, CreateAdminTimeOffRequest body = null);
        
        /// <summary>
        /// Gets a list of time off requests from lookup ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of TimeOffRequestEntityList</returns>
        System.Threading.Tasks.Task<TimeOffRequestEntityList> PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetailsAsync (string muId, TimeOffRequestLookupList body = null);

        /// <summary>
        /// Gets a list of time off requests from lookup ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestEntityList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestEntityList>> PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetailsAsyncWithHttpInfo (string muId, TimeOffRequestLookupList body = null);
        
        /// <summary>
        /// Gets the lookup ids to fetch the specified set of requests
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of TimeOffRequestLookupList</returns>
        System.Threading.Tasks.Task<TimeOffRequestLookupList> PostWorkforcemanagementManagementunitTimeoffrequestsQueryAsync (string muId, TimeOffRequestQueryBody body = null);

        /// <summary>
        /// Gets the lookup ids to fetch the specified set of requests
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestLookupList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestLookupList>> PostWorkforcemanagementManagementunitTimeoffrequestsQueryAsyncWithHttpInfo (string muId, TimeOffRequestQueryBody body = null);
        
        /// <summary>
        /// Copy a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to copy from</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of AsyncWeekScheduleResponse</returns>
        System.Threading.Tasks.Task<AsyncWeekScheduleResponse> PostWorkforcemanagementManagementunitWeekScheduleCopyAsync (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, CopyWeekScheduleRequest body = null);

        /// <summary>
        /// Copy a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to copy from</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (AsyncWeekScheduleResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncWeekScheduleResponse>> PostWorkforcemanagementManagementunitWeekScheduleCopyAsyncWithHttpInfo (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, CopyWeekScheduleRequest body = null);
        
        /// <summary>
        /// Start a scheduling run to compute the reschedule. When the scheduling run finishes, a client can get the reschedule changes and then the client can apply them to the schedule, save the schedule, and mark the scheduling run as applied
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to re-optimize</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of AsyncWeekScheduleResponse</returns>
        System.Threading.Tasks.Task<AsyncWeekScheduleResponse> PostWorkforcemanagementManagementunitWeekScheduleRescheduleAsync (string managementUnitId, string weekId, string scheduleId, RescheduleRequest body = null);

        /// <summary>
        /// Start a scheduling run to compute the reschedule. When the scheduling run finishes, a client can get the reschedule changes and then the client can apply them to the schedule, save the schedule, and mark the scheduling run as applied
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to re-optimize</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (AsyncWeekScheduleResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncWeekScheduleResponse>> PostWorkforcemanagementManagementunitWeekScheduleRescheduleAsyncWithHttpInfo (string managementUnitId, string weekId, string scheduleId, RescheduleRequest body = null);
        
        /// <summary>
        /// Add a schedule for a week in management unit using imported data. Use partial uploads of user schedules if activity count in schedule is greater than 17500
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of AsyncWeekScheduleResponse</returns>
        System.Threading.Tasks.Task<AsyncWeekScheduleResponse> PostWorkforcemanagementManagementunitWeekSchedulesAsync (string managementUnitId, string weekId, bool? forceAsync = null, bool? forceDownloadService = null, ImportWeekScheduleRequest body = null);

        /// <summary>
        /// Add a schedule for a week in management unit using imported data. Use partial uploads of user schedules if activity count in schedule is greater than 17500
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (AsyncWeekScheduleResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncWeekScheduleResponse>> PostWorkforcemanagementManagementunitWeekSchedulesAsyncWithHttpInfo (string managementUnitId, string weekId, bool? forceAsync = null, bool? forceDownloadService = null, ImportWeekScheduleRequest body = null);
        
        /// <summary>
        /// Generate a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of GenerateWeekScheduleResponse</returns>
        System.Threading.Tasks.Task<GenerateWeekScheduleResponse> PostWorkforcemanagementManagementunitWeekSchedulesGenerateAsync (string managementUnitId, string weekId, GenerateWeekScheduleRequest body = null);

        /// <summary>
        /// Generate a week schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (GenerateWeekScheduleResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GenerateWeekScheduleResponse>> PostWorkforcemanagementManagementunitWeekSchedulesGenerateAsyncWithHttpInfo (string managementUnitId, string weekId, GenerateWeekScheduleRequest body = null);
        
        /// <summary>
        /// Partial upload of user schedules where activity count is greater than 17500
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of PartialUploadResponse</returns>
        System.Threading.Tasks.Task<PartialUploadResponse> PostWorkforcemanagementManagementunitWeekSchedulesPartialuploadAsync (string managementUnitId, string weekId, UserSchedulesPartialUploadRequest body = null);

        /// <summary>
        /// Partial upload of user schedules where activity count is greater than 17500
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (PartialUploadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PartialUploadResponse>> PostWorkforcemanagementManagementunitWeekSchedulesPartialuploadAsyncWithHttpInfo (string managementUnitId, string weekId, UserSchedulesPartialUploadRequest body = null);
        
        /// <summary>
        /// Copy a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast to copy</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ShortTermForecastResponse</returns>
        System.Threading.Tasks.Task<ShortTermForecastResponse> PostWorkforcemanagementManagementunitWeekShorttermforecastCopyAsync (string managementUnitId, string weekDateId, string forecastId, CopyShortTermForecastRequest body, bool? forceAsync = null);

        /// <summary>
        /// Copy a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast to copy</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ApiResponse (ShortTermForecastResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShortTermForecastResponse>> PostWorkforcemanagementManagementunitWeekShorttermforecastCopyAsyncWithHttpInfo (string managementUnitId, string weekDateId, string forecastId, CopyShortTermForecastRequest body, bool? forceAsync = null);
        
        /// <summary>
        /// Import a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ShortTermForecastResponse</returns>
        System.Threading.Tasks.Task<ShortTermForecastResponse> PostWorkforcemanagementManagementunitWeekShorttermforecastsAsync (string managementUnitId, string weekDateId, ImportShortTermForecastRequest body, bool? forceAsync = null);

        /// <summary>
        /// Import a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ApiResponse (ShortTermForecastResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShortTermForecastResponse>> PostWorkforcemanagementManagementunitWeekShorttermforecastsAsyncWithHttpInfo (string managementUnitId, string weekDateId, ImportShortTermForecastRequest body, bool? forceAsync = null);
        
        /// <summary>
        /// Generate a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body"></param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>Task of GenerateShortTermForecastResponse</returns>
        System.Threading.Tasks.Task<GenerateShortTermForecastResponse> PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerateAsync (string managementUnitId, string weekDateId, GenerateShortTermForecastRequest body, bool? forceAsync = null);

        /// <summary>
        /// Generate a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body"></param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ApiResponse (GenerateShortTermForecastResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GenerateShortTermForecastResponse>> PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerateAsyncWithHttpInfo (string managementUnitId, string weekDateId, GenerateShortTermForecastRequest body, bool? forceAsync = null);
        
        /// <summary>
        /// Import a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <returns>Task of PartialUploadResponse</returns>
        System.Threading.Tasks.Task<PartialUploadResponse> PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialuploadAsync (string managementUnitId, string weekDateId, RouteGroupList body);

        /// <summary>
        /// Import a short term forecast
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse (PartialUploadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PartialUploadResponse>> PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialuploadAsyncWithHttpInfo (string managementUnitId, string weekDateId, RouteGroupList body);
        
        /// <summary>
        /// Create a copy of work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to create a copy</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WorkPlan</returns>
        System.Threading.Tasks.Task<WorkPlan> PostWorkforcemanagementManagementunitWorkplanCopyAsync (string managementUnitId, string workPlanId, CopyWorkPlan body = null);

        /// <summary>
        /// Create a copy of work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to create a copy</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WorkPlan)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkPlan>> PostWorkforcemanagementManagementunitWorkplanCopyAsyncWithHttpInfo (string managementUnitId, string workPlanId, CopyWorkPlan body = null);
        
        /// <summary>
        /// Create a new work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WorkPlan</returns>
        System.Threading.Tasks.Task<WorkPlan> PostWorkforcemanagementManagementunitWorkplansAsync (string managementUnitId, CreateWorkPlan body = null);

        /// <summary>
        /// Create a new work plan
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WorkPlan)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkPlan>> PostWorkforcemanagementManagementunitWorkplansAsyncWithHttpInfo (string managementUnitId, CreateWorkPlan body = null);
        
        /// <summary>
        /// Add a management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ManagementUnit</returns>
        System.Threading.Tasks.Task<ManagementUnit> PostWorkforcemanagementManagementunitsAsync (CreateManagementUnitApiRequest body = null);

        /// <summary>
        /// Add a management unit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (ManagementUnit)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagementUnit>> PostWorkforcemanagementManagementunitsAsyncWithHttpInfo (CreateManagementUnitApiRequest body = null);
        
        /// <summary>
        /// Get published schedule for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of UserScheduleContainer</returns>
        System.Threading.Tasks.Task<UserScheduleContainer> PostWorkforcemanagementSchedulesAsync (CurrentUserScheduleRequestBody body = null);

        /// <summary>
        /// Get published schedule for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (UserScheduleContainer)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserScheduleContainer>> PostWorkforcemanagementSchedulesAsyncWithHttpInfo (CurrentUserScheduleRequestBody body = null);
        
        /// <summary>
        /// Create a time off request for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of TimeOffRequestResponse</returns>
        System.Threading.Tasks.Task<TimeOffRequestResponse> PostWorkforcemanagementTimeoffrequestsAsync (CreateAgentTimeOffRequest body = null);

        /// <summary>
        /// Create a time off request for the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeOffRequestResponse>> PostWorkforcemanagementTimeoffrequestsAsyncWithHttpInfo (CreateAgentTimeOffRequest body = null);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WorkforceManagementApi : IWorkforceManagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkforceManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorkforceManagementApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkforceManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WorkforceManagementApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = PureCloudPlatform.Client.V2.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'this.Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PureCloudPlatform.Client.V2.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use this.Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use this.Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        
        /// <summary>
        /// Delete management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns></returns>
        public void DeleteWorkforcemanagementManagementunit (string muId)
        {
             DeleteWorkforcemanagementManagementunitWithHttpInfo(muId);
        }

        /// <summary>
        /// Delete management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWorkforcemanagementManagementunitWithHttpInfo (string muId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunit");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunit: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWorkforcemanagementManagementunitAsync (string muId)
        {
             await DeleteWorkforcemanagementManagementunitAsyncWithHttpInfo(muId);

        }

        /// <summary>
        /// Delete management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkforcemanagementManagementunitAsyncWithHttpInfo (string muId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunit");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunit: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Deletes an activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to delete</param>
        /// <returns></returns>
        public void DeleteWorkforcemanagementManagementunitActivitycode (string muId, string acId)
        {
             DeleteWorkforcemanagementManagementunitActivitycodeWithHttpInfo(muId, acId);
        }

        /// <summary>
        /// Deletes an activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWorkforcemanagementManagementunitActivitycodeWithHttpInfo (string muId, string acId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitActivitycode");
            // verify the required parameter 'acId' is set
            if (acId == null)
                throw new ApiException(400, "Missing required parameter 'acId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitActivitycode");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/activitycodes/{acId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (acId != null) localVarPathParams.Add("acId", this.Configuration.ApiClient.ParameterToString(acId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitActivitycode: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitActivitycode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Deletes an activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWorkforcemanagementManagementunitActivitycodeAsync (string muId, string acId)
        {
             await DeleteWorkforcemanagementManagementunitActivitycodeAsyncWithHttpInfo(muId, acId);

        }

        /// <summary>
        /// Deletes an activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkforcemanagementManagementunitActivitycodeAsyncWithHttpInfo (string muId, string acId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitActivitycode");
            
            // verify the required parameter 'acId' is set
            if (acId == null)
                throw new ApiException(400, "Missing required parameter 'acId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitActivitycode");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/activitycodes/{acId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (acId != null) localVarPathParams.Add("acId", this.Configuration.ApiClient.ParameterToString(acId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitActivitycode: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitActivitycode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Cancel a schedule run 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns></returns>
        public void DeleteWorkforcemanagementManagementunitSchedulingRun (string managementUnitId, string runId)
        {
             DeleteWorkforcemanagementManagementunitSchedulingRunWithHttpInfo(managementUnitId, runId);
        }

        /// <summary>
        /// Cancel a schedule run 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWorkforcemanagementManagementunitSchedulingRunWithHttpInfo (string managementUnitId, string runId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitSchedulingRun");
            // verify the required parameter 'runId' is set
            if (runId == null)
                throw new ApiException(400, "Missing required parameter 'runId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitSchedulingRun");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (runId != null) localVarPathParams.Add("runId", this.Configuration.ApiClient.ParameterToString(runId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitSchedulingRun: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitSchedulingRun: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Cancel a schedule run 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWorkforcemanagementManagementunitSchedulingRunAsync (string managementUnitId, string runId)
        {
             await DeleteWorkforcemanagementManagementunitSchedulingRunAsyncWithHttpInfo(managementUnitId, runId);

        }

        /// <summary>
        /// Cancel a schedule run 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkforcemanagementManagementunitSchedulingRunAsyncWithHttpInfo (string managementUnitId, string runId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitSchedulingRun");
            
            // verify the required parameter 'runId' is set
            if (runId == null)
                throw new ApiException(400, "Missing required parameter 'runId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitSchedulingRun");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (runId != null) localVarPathParams.Add("runId", this.Configuration.ApiClient.ParameterToString(runId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitSchedulingRun: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitSchedulingRun: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Delete a service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to delete</param>
        /// <returns></returns>
        public void DeleteWorkforcemanagementManagementunitServicegoalgroup (string managementUnitId, string serviceGoalGroupId)
        {
             DeleteWorkforcemanagementManagementunitServicegoalgroupWithHttpInfo(managementUnitId, serviceGoalGroupId);
        }

        /// <summary>
        /// Delete a service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWorkforcemanagementManagementunitServicegoalgroupWithHttpInfo (string managementUnitId, string serviceGoalGroupId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitServicegoalgroup");
            // verify the required parameter 'serviceGoalGroupId' is set
            if (serviceGoalGroupId == null)
                throw new ApiException(400, "Missing required parameter 'serviceGoalGroupId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitServicegoalgroup");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups/{serviceGoalGroupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (serviceGoalGroupId != null) localVarPathParams.Add("serviceGoalGroupId", this.Configuration.ApiClient.ParameterToString(serviceGoalGroupId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitServicegoalgroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitServicegoalgroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete a service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWorkforcemanagementManagementunitServicegoalgroupAsync (string managementUnitId, string serviceGoalGroupId)
        {
             await DeleteWorkforcemanagementManagementunitServicegoalgroupAsyncWithHttpInfo(managementUnitId, serviceGoalGroupId);

        }

        /// <summary>
        /// Delete a service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkforcemanagementManagementunitServicegoalgroupAsyncWithHttpInfo (string managementUnitId, string serviceGoalGroupId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitServicegoalgroup");
            
            // verify the required parameter 'serviceGoalGroupId' is set
            if (serviceGoalGroupId == null)
                throw new ApiException(400, "Missing required parameter 'serviceGoalGroupId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitServicegoalgroup");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups/{serviceGoalGroupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (serviceGoalGroupId != null) localVarPathParams.Add("serviceGoalGroupId", this.Configuration.ApiClient.ParameterToString(serviceGoalGroupId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitServicegoalgroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitServicegoalgroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Delete a schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of theschedule to delete</param>
        /// <returns></returns>
        public void DeleteWorkforcemanagementManagementunitWeekSchedule (string managementUnitId, string weekId, string scheduleId)
        {
             DeleteWorkforcemanagementManagementunitWeekScheduleWithHttpInfo(managementUnitId, weekId, scheduleId);
        }

        /// <summary>
        /// Delete a schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of theschedule to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWorkforcemanagementManagementunitWeekScheduleWithHttpInfo (string managementUnitId, string weekId, string scheduleId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWeekSchedule");
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWeekSchedule");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWeekSchedule");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));
            if (scheduleId != null) localVarPathParams.Add("scheduleId", this.Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitWeekSchedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitWeekSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete a schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of theschedule to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWorkforcemanagementManagementunitWeekScheduleAsync (string managementUnitId, string weekId, string scheduleId)
        {
             await DeleteWorkforcemanagementManagementunitWeekScheduleAsyncWithHttpInfo(managementUnitId, weekId, scheduleId);

        }

        /// <summary>
        /// Delete a schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of theschedule to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkforcemanagementManagementunitWeekScheduleAsyncWithHttpInfo (string managementUnitId, string weekId, string scheduleId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWeekSchedule");
            
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWeekSchedule");
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWeekSchedule");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));
            if (scheduleId != null) localVarPathParams.Add("scheduleId", this.Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitWeekSchedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitWeekSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Delete a short term forecast Must not be tied to any schedules
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <returns></returns>
        public void DeleteWorkforcemanagementManagementunitWeekShorttermforecast (string managementUnitId, string weekDateId, string forecastId)
        {
             DeleteWorkforcemanagementManagementunitWeekShorttermforecastWithHttpInfo(managementUnitId, weekDateId, forecastId);
        }

        /// <summary>
        /// Delete a short term forecast Must not be tied to any schedules
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWorkforcemanagementManagementunitWeekShorttermforecastWithHttpInfo (string managementUnitId, string weekDateId, string forecastId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWeekShorttermforecast");
            // verify the required parameter 'weekDateId' is set
            if (weekDateId == null)
                throw new ApiException(400, "Missing required parameter 'weekDateId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWeekShorttermforecast");
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWeekShorttermforecast");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekDateId != null) localVarPathParams.Add("weekDateId", this.Configuration.ApiClient.ParameterToString(weekDateId));
            if (forecastId != null) localVarPathParams.Add("forecastId", this.Configuration.ApiClient.ParameterToString(forecastId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitWeekShorttermforecast: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitWeekShorttermforecast: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete a short term forecast Must not be tied to any schedules
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWorkforcemanagementManagementunitWeekShorttermforecastAsync (string managementUnitId, string weekDateId, string forecastId)
        {
             await DeleteWorkforcemanagementManagementunitWeekShorttermforecastAsyncWithHttpInfo(managementUnitId, weekDateId, forecastId);

        }

        /// <summary>
        /// Delete a short term forecast Must not be tied to any schedules
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkforcemanagementManagementunitWeekShorttermforecastAsyncWithHttpInfo (string managementUnitId, string weekDateId, string forecastId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWeekShorttermforecast");
            
            // verify the required parameter 'weekDateId' is set
            if (weekDateId == null)
                throw new ApiException(400, "Missing required parameter 'weekDateId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWeekShorttermforecast");
            
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWeekShorttermforecast");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekDateId != null) localVarPathParams.Add("weekDateId", this.Configuration.ApiClient.ParameterToString(weekDateId));
            if (forecastId != null) localVarPathParams.Add("forecastId", this.Configuration.ApiClient.ParameterToString(forecastId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitWeekShorttermforecast: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitWeekShorttermforecast: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Delete a work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to delete</param>
        /// <returns></returns>
        public void DeleteWorkforcemanagementManagementunitWorkplan (string managementUnitId, string workPlanId)
        {
             DeleteWorkforcemanagementManagementunitWorkplanWithHttpInfo(managementUnitId, workPlanId);
        }

        /// <summary>
        /// Delete a work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWorkforcemanagementManagementunitWorkplanWithHttpInfo (string managementUnitId, string workPlanId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWorkplan");
            // verify the required parameter 'workPlanId' is set
            if (workPlanId == null)
                throw new ApiException(400, "Missing required parameter 'workPlanId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWorkplan");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (workPlanId != null) localVarPathParams.Add("workPlanId", this.Configuration.ApiClient.ParameterToString(workPlanId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitWorkplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitWorkplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete a work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWorkforcemanagementManagementunitWorkplanAsync (string managementUnitId, string workPlanId)
        {
             await DeleteWorkforcemanagementManagementunitWorkplanAsyncWithHttpInfo(managementUnitId, workPlanId);

        }

        /// <summary>
        /// Delete a work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkforcemanagementManagementunitWorkplanAsyncWithHttpInfo (string managementUnitId, string workPlanId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWorkplan");
            
            // verify the required parameter 'workPlanId' is set
            if (workPlanId == null)
                throw new ApiException(400, "Missing required parameter 'workPlanId' when calling WorkforceManagementApi->DeleteWorkforcemanagementManagementunitWorkplan");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (workPlanId != null) localVarPathParams.Add("workPlanId", this.Configuration.ApiClient.ParameterToString(workPlanId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitWorkplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkforcemanagementManagementunitWorkplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>List&lt;UserScheduleAdherence&gt;</returns>
        public List<UserScheduleAdherence> GetWorkforcemanagementAdherence (List<string> userId)
        {
             ApiResponse<List<UserScheduleAdherence>> localVarResponse = GetWorkforcemanagementAdherenceWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>ApiResponse of List&lt;UserScheduleAdherence&gt;</returns>
        public ApiResponse< List<UserScheduleAdherence> > GetWorkforcemanagementAdherenceWithHttpInfo (List<string> userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetWorkforcemanagementAdherence");

            var localVarPath = "/api/v2/workforcemanagement/adherence";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (userId != null) userId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("userId", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementAdherence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementAdherence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<UserScheduleAdherence>>(localVarStatusCode,
                localVarHeaders,
                (List<UserScheduleAdherence>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserScheduleAdherence>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>Task of List&lt;UserScheduleAdherence&gt;</returns>
        public async System.Threading.Tasks.Task<List<UserScheduleAdherence>> GetWorkforcemanagementAdherenceAsync (List<string> userId)
        {
             ApiResponse<List<UserScheduleAdherence>> localVarResponse = await GetWorkforcemanagementAdherenceAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of UserScheduleAdherence records for the requested users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User Id(s) for which to fetch current schedule adherence information.  Min 1, Max of 100 userIds per request</param>
        /// <returns>Task of ApiResponse (List&lt;UserScheduleAdherence&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<UserScheduleAdherence>>> GetWorkforcemanagementAdherenceAsyncWithHttpInfo (List<string> userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetWorkforcemanagementAdherence");
            

            var localVarPath = "/api/v2/workforcemanagement/adherence";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (userId != null) userId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("userId", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementAdherence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementAdherence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<UserScheduleAdherence>>(localVarStatusCode,
                localVarHeaders,
                (List<UserScheduleAdherence>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserScheduleAdherence>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>ManagementUnit</returns>
        public ManagementUnit GetWorkforcemanagementManagementunit (string muId, string expand = null)
        {
             ApiResponse<ManagementUnit> localVarResponse = GetWorkforcemanagementManagementunitWithHttpInfo(muId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>ApiResponse of ManagementUnit</returns>
        public ApiResponse< ManagementUnit > GetWorkforcemanagementManagementunitWithHttpInfo (string muId, string expand = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunit");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunit: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnit>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnit) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnit)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>Task of ManagementUnit</returns>
        public async System.Threading.Tasks.Task<ManagementUnit> GetWorkforcemanagementManagementunitAsync (string muId, string expand = null)
        {
             ApiResponse<ManagementUnit> localVarResponse = await GetWorkforcemanagementManagementunitAsyncWithHttpInfo(muId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>Task of ApiResponse (ManagementUnit)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagementUnit>> GetWorkforcemanagementManagementunitAsyncWithHttpInfo (string muId, string expand = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunit");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunit: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnit>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnit) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnit)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get an activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to fetch</param>
        /// <returns>ActivityCode</returns>
        public ActivityCode GetWorkforcemanagementManagementunitActivitycode (string muId, string acId)
        {
             ApiResponse<ActivityCode> localVarResponse = GetWorkforcemanagementManagementunitActivitycodeWithHttpInfo(muId, acId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to fetch</param>
        /// <returns>ApiResponse of ActivityCode</returns>
        public ApiResponse< ActivityCode > GetWorkforcemanagementManagementunitActivitycodeWithHttpInfo (string muId, string acId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitActivitycode");
            // verify the required parameter 'acId' is set
            if (acId == null)
                throw new ApiException(400, "Missing required parameter 'acId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitActivitycode");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/activitycodes/{acId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (acId != null) localVarPathParams.Add("acId", this.Configuration.ApiClient.ParameterToString(acId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycode: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActivityCode>(localVarStatusCode,
                localVarHeaders,
                (ActivityCode) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCode)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get an activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to fetch</param>
        /// <returns>Task of ActivityCode</returns>
        public async System.Threading.Tasks.Task<ActivityCode> GetWorkforcemanagementManagementunitActivitycodeAsync (string muId, string acId)
        {
             ApiResponse<ActivityCode> localVarResponse = await GetWorkforcemanagementManagementunitActivitycodeAsyncWithHttpInfo(muId, acId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to fetch</param>
        /// <returns>Task of ApiResponse (ActivityCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ActivityCode>> GetWorkforcemanagementManagementunitActivitycodeAsyncWithHttpInfo (string muId, string acId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitActivitycode");
            
            // verify the required parameter 'acId' is set
            if (acId == null)
                throw new ApiException(400, "Missing required parameter 'acId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitActivitycode");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/activitycodes/{acId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (acId != null) localVarPathParams.Add("acId", this.Configuration.ApiClient.ParameterToString(acId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycode: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActivityCode>(localVarStatusCode,
                localVarHeaders,
                (ActivityCode) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCode)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get activity codes 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ActivityCodeContainer</returns>
        public ActivityCodeContainer GetWorkforcemanagementManagementunitActivitycodes (string muId)
        {
             ApiResponse<ActivityCodeContainer> localVarResponse = GetWorkforcemanagementManagementunitActivitycodesWithHttpInfo(muId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get activity codes 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of ActivityCodeContainer</returns>
        public ApiResponse< ActivityCodeContainer > GetWorkforcemanagementManagementunitActivitycodesWithHttpInfo (string muId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitActivitycodes");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/activitycodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActivityCodeContainer>(localVarStatusCode,
                localVarHeaders,
                (ActivityCodeContainer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCodeContainer)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get activity codes 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ActivityCodeContainer</returns>
        public async System.Threading.Tasks.Task<ActivityCodeContainer> GetWorkforcemanagementManagementunitActivitycodesAsync (string muId)
        {
             ApiResponse<ActivityCodeContainer> localVarResponse = await GetWorkforcemanagementManagementunitActivitycodesAsyncWithHttpInfo(muId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get activity codes 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse (ActivityCodeContainer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ActivityCodeContainer>> GetWorkforcemanagementManagementunitActivitycodesAsyncWithHttpInfo (string muId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitActivitycodes");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/activitycodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActivityCodeContainer>(localVarStatusCode,
                localVarHeaders,
                (ActivityCodeContainer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCodeContainer)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get data for agent in the management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The id of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="agentId">The agent id</param>
        /// <returns>WfmAgent</returns>
        public WfmAgent GetWorkforcemanagementManagementunitAgent (string managementUnitId, string agentId)
        {
             ApiResponse<WfmAgent> localVarResponse = GetWorkforcemanagementManagementunitAgentWithHttpInfo(managementUnitId, agentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get data for agent in the management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The id of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="agentId">The agent id</param>
        /// <returns>ApiResponse of WfmAgent</returns>
        public ApiResponse< WfmAgent > GetWorkforcemanagementManagementunitAgentWithHttpInfo (string managementUnitId, string agentId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitAgent");
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitAgent");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/{agentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (agentId != null) localVarPathParams.Add("agentId", this.Configuration.ApiClient.ParameterToString(agentId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitAgent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitAgent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmAgent>(localVarStatusCode,
                localVarHeaders,
                (WfmAgent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmAgent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get data for agent in the management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The id of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="agentId">The agent id</param>
        /// <returns>Task of WfmAgent</returns>
        public async System.Threading.Tasks.Task<WfmAgent> GetWorkforcemanagementManagementunitAgentAsync (string managementUnitId, string agentId)
        {
             ApiResponse<WfmAgent> localVarResponse = await GetWorkforcemanagementManagementunitAgentAsyncWithHttpInfo(managementUnitId, agentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get data for agent in the management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The id of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="agentId">The agent id</param>
        /// <returns>Task of ApiResponse (WfmAgent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WfmAgent>> GetWorkforcemanagementManagementunitAgentAsyncWithHttpInfo (string managementUnitId, string agentId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitAgent");
            
            // verify the required parameter 'agentId' is set
            if (agentId == null)
                throw new ApiException(400, "Missing required parameter 'agentId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitAgent");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/agents/{agentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (agentId != null) localVarPathParams.Add("agentId", this.Configuration.ApiClient.ParameterToString(agentId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitAgent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitAgent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmAgent>(localVarStatusCode,
                localVarHeaders,
                (WfmAgent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmAgent)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get intraday queues for the given date 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="date">yyyy-MM-dd date string interpreted in the configured management unit time zone</param>
        /// <returns>WfmIntradayQueueListing</returns>
        public WfmIntradayQueueListing GetWorkforcemanagementManagementunitIntradayQueues (string muId, string date)
        {
             ApiResponse<WfmIntradayQueueListing> localVarResponse = GetWorkforcemanagementManagementunitIntradayQueuesWithHttpInfo(muId, date);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get intraday queues for the given date 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="date">yyyy-MM-dd date string interpreted in the configured management unit time zone</param>
        /// <returns>ApiResponse of WfmIntradayQueueListing</returns>
        public ApiResponse< WfmIntradayQueueListing > GetWorkforcemanagementManagementunitIntradayQueuesWithHttpInfo (string muId, string date)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitIntradayQueues");
            // verify the required parameter 'date' is set
            if (date == null)
                throw new ApiException(400, "Missing required parameter 'date' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitIntradayQueues");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/intraday/queues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params
            if (date != null) localVarQueryParams.Add(new Tuple<string, string>("date", this.Configuration.ApiClient.ParameterToString(date)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitIntradayQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitIntradayQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmIntradayQueueListing>(localVarStatusCode,
                localVarHeaders,
                (WfmIntradayQueueListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmIntradayQueueListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get intraday queues for the given date 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="date">yyyy-MM-dd date string interpreted in the configured management unit time zone</param>
        /// <returns>Task of WfmIntradayQueueListing</returns>
        public async System.Threading.Tasks.Task<WfmIntradayQueueListing> GetWorkforcemanagementManagementunitIntradayQueuesAsync (string muId, string date)
        {
             ApiResponse<WfmIntradayQueueListing> localVarResponse = await GetWorkforcemanagementManagementunitIntradayQueuesAsyncWithHttpInfo(muId, date);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get intraday queues for the given date 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="date">yyyy-MM-dd date string interpreted in the configured management unit time zone</param>
        /// <returns>Task of ApiResponse (WfmIntradayQueueListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WfmIntradayQueueListing>> GetWorkforcemanagementManagementunitIntradayQueuesAsyncWithHttpInfo (string muId, string date)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitIntradayQueues");
            
            // verify the required parameter 'date' is set
            if (date == null)
                throw new ApiException(400, "Missing required parameter 'date' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitIntradayQueues");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/intraday/queues";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params
            if (date != null) localVarQueryParams.Add(new Tuple<string, string>("date", this.Configuration.ApiClient.ParameterToString(date)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitIntradayQueues: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitIntradayQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmIntradayQueueListing>(localVarStatusCode,
                localVarHeaders,
                (WfmIntradayQueueListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmIntradayQueueListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Gets the status for a specific scheduling run 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>SchedulingRunResponse</returns>
        public SchedulingRunResponse GetWorkforcemanagementManagementunitSchedulingRun (string managementUnitId, string runId)
        {
             ApiResponse<SchedulingRunResponse> localVarResponse = GetWorkforcemanagementManagementunitSchedulingRunWithHttpInfo(managementUnitId, runId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the status for a specific scheduling run 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>ApiResponse of SchedulingRunResponse</returns>
        public ApiResponse< SchedulingRunResponse > GetWorkforcemanagementManagementunitSchedulingRunWithHttpInfo (string managementUnitId, string runId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitSchedulingRun");
            // verify the required parameter 'runId' is set
            if (runId == null)
                throw new ApiException(400, "Missing required parameter 'runId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitSchedulingRun");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (runId != null) localVarPathParams.Add("runId", this.Configuration.ApiClient.ParameterToString(runId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSchedulingRun: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSchedulingRun: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchedulingRunResponse>(localVarStatusCode,
                localVarHeaders,
                (SchedulingRunResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchedulingRunResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Gets the status for a specific scheduling run 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>Task of SchedulingRunResponse</returns>
        public async System.Threading.Tasks.Task<SchedulingRunResponse> GetWorkforcemanagementManagementunitSchedulingRunAsync (string managementUnitId, string runId)
        {
             ApiResponse<SchedulingRunResponse> localVarResponse = await GetWorkforcemanagementManagementunitSchedulingRunAsyncWithHttpInfo(managementUnitId, runId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the status for a specific scheduling run 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>Task of ApiResponse (SchedulingRunResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchedulingRunResponse>> GetWorkforcemanagementManagementunitSchedulingRunAsyncWithHttpInfo (string managementUnitId, string runId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitSchedulingRun");
            
            // verify the required parameter 'runId' is set
            if (runId == null)
                throw new ApiException(400, "Missing required parameter 'runId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitSchedulingRun");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (runId != null) localVarPathParams.Add("runId", this.Configuration.ApiClient.ParameterToString(runId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSchedulingRun: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSchedulingRun: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchedulingRunResponse>(localVarStatusCode,
                localVarHeaders,
                (SchedulingRunResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchedulingRunResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Gets the result of a specific scheduling run 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>RescheduleResult</returns>
        public RescheduleResult GetWorkforcemanagementManagementunitSchedulingRunResult (string managementUnitId, string runId)
        {
             ApiResponse<RescheduleResult> localVarResponse = GetWorkforcemanagementManagementunitSchedulingRunResultWithHttpInfo(managementUnitId, runId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the result of a specific scheduling run 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>ApiResponse of RescheduleResult</returns>
        public ApiResponse< RescheduleResult > GetWorkforcemanagementManagementunitSchedulingRunResultWithHttpInfo (string managementUnitId, string runId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitSchedulingRunResult");
            // verify the required parameter 'runId' is set
            if (runId == null)
                throw new ApiException(400, "Missing required parameter 'runId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitSchedulingRunResult");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId}/result";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (runId != null) localVarPathParams.Add("runId", this.Configuration.ApiClient.ParameterToString(runId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSchedulingRunResult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSchedulingRunResult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RescheduleResult>(localVarStatusCode,
                localVarHeaders,
                (RescheduleResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RescheduleResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Gets the result of a specific scheduling run 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>Task of RescheduleResult</returns>
        public async System.Threading.Tasks.Task<RescheduleResult> GetWorkforcemanagementManagementunitSchedulingRunResultAsync (string managementUnitId, string runId)
        {
             ApiResponse<RescheduleResult> localVarResponse = await GetWorkforcemanagementManagementunitSchedulingRunResultAsyncWithHttpInfo(managementUnitId, runId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the result of a specific scheduling run 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <returns>Task of ApiResponse (RescheduleResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RescheduleResult>> GetWorkforcemanagementManagementunitSchedulingRunResultAsyncWithHttpInfo (string managementUnitId, string runId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitSchedulingRunResult");
            
            // verify the required parameter 'runId' is set
            if (runId == null)
                throw new ApiException(400, "Missing required parameter 'runId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitSchedulingRunResult");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId}/result";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (runId != null) localVarPathParams.Add("runId", this.Configuration.ApiClient.ParameterToString(runId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSchedulingRunResult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSchedulingRunResult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RescheduleResult>(localVarStatusCode,
                localVarHeaders,
                (RescheduleResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RescheduleResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get the status of all the ongoing schedule runs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <returns>SchedulingRunListResponse</returns>
        public SchedulingRunListResponse GetWorkforcemanagementManagementunitSchedulingRuns (string managementUnitId)
        {
             ApiResponse<SchedulingRunListResponse> localVarResponse = GetWorkforcemanagementManagementunitSchedulingRunsWithHttpInfo(managementUnitId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of all the ongoing schedule runs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <returns>ApiResponse of SchedulingRunListResponse</returns>
        public ApiResponse< SchedulingRunListResponse > GetWorkforcemanagementManagementunitSchedulingRunsWithHttpInfo (string managementUnitId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitSchedulingRuns");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSchedulingRuns: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSchedulingRuns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchedulingRunListResponse>(localVarStatusCode,
                localVarHeaders,
                (SchedulingRunListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchedulingRunListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get the status of all the ongoing schedule runs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <returns>Task of SchedulingRunListResponse</returns>
        public async System.Threading.Tasks.Task<SchedulingRunListResponse> GetWorkforcemanagementManagementunitSchedulingRunsAsync (string managementUnitId)
        {
             ApiResponse<SchedulingRunListResponse> localVarResponse = await GetWorkforcemanagementManagementunitSchedulingRunsAsyncWithHttpInfo(managementUnitId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the status of all the ongoing schedule runs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <returns>Task of ApiResponse (SchedulingRunListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchedulingRunListResponse>> GetWorkforcemanagementManagementunitSchedulingRunsAsyncWithHttpInfo (string managementUnitId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitSchedulingRuns");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSchedulingRuns: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSchedulingRuns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchedulingRunListResponse>(localVarStatusCode,
                localVarHeaders,
                (SchedulingRunListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchedulingRunListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to fetch</param>
        /// <returns>ServiceGoalGroup</returns>
        public ServiceGoalGroup GetWorkforcemanagementManagementunitServicegoalgroup (string managementUnitId, string serviceGoalGroupId)
        {
             ApiResponse<ServiceGoalGroup> localVarResponse = GetWorkforcemanagementManagementunitServicegoalgroupWithHttpInfo(managementUnitId, serviceGoalGroupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to fetch</param>
        /// <returns>ApiResponse of ServiceGoalGroup</returns>
        public ApiResponse< ServiceGoalGroup > GetWorkforcemanagementManagementunitServicegoalgroupWithHttpInfo (string managementUnitId, string serviceGoalGroupId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitServicegoalgroup");
            // verify the required parameter 'serviceGoalGroupId' is set
            if (serviceGoalGroupId == null)
                throw new ApiException(400, "Missing required parameter 'serviceGoalGroupId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitServicegoalgroup");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups/{serviceGoalGroupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (serviceGoalGroupId != null) localVarPathParams.Add("serviceGoalGroupId", this.Configuration.ApiClient.ParameterToString(serviceGoalGroupId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitServicegoalgroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitServicegoalgroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ServiceGoalGroup>(localVarStatusCode,
                localVarHeaders,
                (ServiceGoalGroup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceGoalGroup)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to fetch</param>
        /// <returns>Task of ServiceGoalGroup</returns>
        public async System.Threading.Tasks.Task<ServiceGoalGroup> GetWorkforcemanagementManagementunitServicegoalgroupAsync (string managementUnitId, string serviceGoalGroupId)
        {
             ApiResponse<ServiceGoalGroup> localVarResponse = await GetWorkforcemanagementManagementunitServicegoalgroupAsyncWithHttpInfo(managementUnitId, serviceGoalGroupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to fetch</param>
        /// <returns>Task of ApiResponse (ServiceGoalGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServiceGoalGroup>> GetWorkforcemanagementManagementunitServicegoalgroupAsyncWithHttpInfo (string managementUnitId, string serviceGoalGroupId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitServicegoalgroup");
            
            // verify the required parameter 'serviceGoalGroupId' is set
            if (serviceGoalGroupId == null)
                throw new ApiException(400, "Missing required parameter 'serviceGoalGroupId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitServicegoalgroup");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups/{serviceGoalGroupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (serviceGoalGroupId != null) localVarPathParams.Add("serviceGoalGroupId", this.Configuration.ApiClient.ParameterToString(serviceGoalGroupId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitServicegoalgroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitServicegoalgroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ServiceGoalGroup>(localVarStatusCode,
                localVarHeaders,
                (ServiceGoalGroup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceGoalGroup)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get service goal groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ServiceGoalGroupList</returns>
        public ServiceGoalGroupList GetWorkforcemanagementManagementunitServicegoalgroups (string managementUnitId)
        {
             ApiResponse<ServiceGoalGroupList> localVarResponse = GetWorkforcemanagementManagementunitServicegoalgroupsWithHttpInfo(managementUnitId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get service goal groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of ServiceGoalGroupList</returns>
        public ApiResponse< ServiceGoalGroupList > GetWorkforcemanagementManagementunitServicegoalgroupsWithHttpInfo (string managementUnitId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitServicegoalgroups");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitServicegoalgroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitServicegoalgroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ServiceGoalGroupList>(localVarStatusCode,
                localVarHeaders,
                (ServiceGoalGroupList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceGoalGroupList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get service goal groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ServiceGoalGroupList</returns>
        public async System.Threading.Tasks.Task<ServiceGoalGroupList> GetWorkforcemanagementManagementunitServicegoalgroupsAsync (string managementUnitId)
        {
             ApiResponse<ServiceGoalGroupList> localVarResponse = await GetWorkforcemanagementManagementunitServicegoalgroupsAsyncWithHttpInfo(managementUnitId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get service goal groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse (ServiceGoalGroupList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServiceGoalGroupList>> GetWorkforcemanagementManagementunitServicegoalgroupsAsyncWithHttpInfo (string managementUnitId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitServicegoalgroups");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitServicegoalgroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitServicegoalgroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ServiceGoalGroupList>(localVarStatusCode,
                localVarHeaders,
                (ServiceGoalGroupList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceGoalGroupList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get the settings for the requested management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ManagementUnitSettings</returns>
        public ManagementUnitSettings GetWorkforcemanagementManagementunitSettings (string muId)
        {
             ApiResponse<ManagementUnitSettings> localVarResponse = GetWorkforcemanagementManagementunitSettingsWithHttpInfo(muId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the settings for the requested management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of ManagementUnitSettings</returns>
        public ApiResponse< ManagementUnitSettings > GetWorkforcemanagementManagementunitSettingsWithHttpInfo (string muId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitSettings");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnitSettings>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnitSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnitSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get the settings for the requested management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ManagementUnitSettings</returns>
        public async System.Threading.Tasks.Task<ManagementUnitSettings> GetWorkforcemanagementManagementunitSettingsAsync (string muId)
        {
             ApiResponse<ManagementUnitSettings> localVarResponse = await GetWorkforcemanagementManagementunitSettingsAsyncWithHttpInfo(muId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the settings for the requested management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse (ManagementUnitSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagementUnitSettings>> GetWorkforcemanagementManagementunitSettingsAsyncWithHttpInfo (string muId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitSettings");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnitSettings>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnitSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnitSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>TimeOffRequestResponse</returns>
        public TimeOffRequestResponse GetWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId)
        {
             ApiResponse<TimeOffRequestResponse> localVarResponse = GetWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo(muId, userId, timeOffRequestId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>ApiResponse of TimeOffRequestResponse</returns>
        public ApiResponse< TimeOffRequestResponse > GetWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo (string muId, string userId, string timeOffRequestId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequest");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequest");
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequest");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", this.Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestResponse>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of TimeOffRequestResponse</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestResponse> GetWorkforcemanagementManagementunitUserTimeoffrequestAsync (string muId, string userId, string timeOffRequestId)
        {
             ApiResponse<TimeOffRequestResponse> localVarResponse = await GetWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo(muId, userId, timeOffRequestId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of ApiResponse (TimeOffRequestResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestResponse>> GetWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo (string muId, string userId, string timeOffRequestId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequest");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequest");
            
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequest");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", this.Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestResponse>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of time off requests for a given user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>TimeOffRequestList</returns>
        public TimeOffRequestList GetWorkforcemanagementManagementunitUserTimeoffrequests (string muId, string userId, bool? recentlyReviewed = null)
        {
             ApiResponse<TimeOffRequestList> localVarResponse = GetWorkforcemanagementManagementunitUserTimeoffrequestsWithHttpInfo(muId, userId, recentlyReviewed);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of time off requests for a given user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>ApiResponse of TimeOffRequestList</returns>
        public ApiResponse< TimeOffRequestList > GetWorkforcemanagementManagementunitUserTimeoffrequestsWithHttpInfo (string muId, string userId, bool? recentlyReviewed = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequests");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequests");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (recentlyReviewed != null) localVarQueryParams.Add(new Tuple<string, string>("recentlyReviewed", this.Configuration.ApiClient.ParameterToString(recentlyReviewed)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of time off requests for a given user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of TimeOffRequestList</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestList> GetWorkforcemanagementManagementunitUserTimeoffrequestsAsync (string muId, string userId, bool? recentlyReviewed = null)
        {
             ApiResponse<TimeOffRequestList> localVarResponse = await GetWorkforcemanagementManagementunitUserTimeoffrequestsAsyncWithHttpInfo(muId, userId, recentlyReviewed);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of time off requests for a given user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The userId to whom the Time Off Request applies.</param>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestList>> GetWorkforcemanagementManagementunitUserTimeoffrequestsAsyncWithHttpInfo (string muId, string userId, bool? recentlyReviewed = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequests");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUserTimeoffrequests");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (recentlyReviewed != null) localVarQueryParams.Add(new Tuple<string, string>("recentlyReviewed", this.Configuration.ApiClient.ParameterToString(recentlyReviewed)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUserTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get users in the management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>WfmUserEntityListing</returns>
        public WfmUserEntityListing GetWorkforcemanagementManagementunitUsers (string muId)
        {
             ApiResponse<WfmUserEntityListing> localVarResponse = GetWorkforcemanagementManagementunitUsersWithHttpInfo(muId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get users in the management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>ApiResponse of WfmUserEntityListing</returns>
        public ApiResponse< WfmUserEntityListing > GetWorkforcemanagementManagementunitUsersWithHttpInfo (string muId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUsers");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmUserEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WfmUserEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmUserEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get users in the management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of WfmUserEntityListing</returns>
        public async System.Threading.Tasks.Task<WfmUserEntityListing> GetWorkforcemanagementManagementunitUsersAsync (string muId)
        {
             ApiResponse<WfmUserEntityListing> localVarResponse = await GetWorkforcemanagementManagementunitUsersAsyncWithHttpInfo(muId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get users in the management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <returns>Task of ApiResponse (WfmUserEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WfmUserEntityListing>> GetWorkforcemanagementManagementunitUsersAsyncWithHttpInfo (string muId)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitUsers");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmUserEntityListing>(localVarStatusCode,
                localVarHeaders,
                (WfmUserEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmUserEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>WeekScheduleResponse</returns>
        public WeekScheduleResponse GetWorkforcemanagementManagementunitWeekSchedule (string managementUnitId, string weekId, string scheduleId, string expand = null, bool? forceDownloadService = null)
        {
             ApiResponse<WeekScheduleResponse> localVarResponse = GetWorkforcemanagementManagementunitWeekScheduleWithHttpInfo(managementUnitId, weekId, scheduleId, expand, forceDownloadService);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>ApiResponse of WeekScheduleResponse</returns>
        public ApiResponse< WeekScheduleResponse > GetWorkforcemanagementManagementunitWeekScheduleWithHttpInfo (string managementUnitId, string weekId, string scheduleId, string expand = null, bool? forceDownloadService = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekSchedule");
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekSchedule");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekSchedule");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));
            if (scheduleId != null) localVarPathParams.Add("scheduleId", this.Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (forceDownloadService != null) localVarQueryParams.Add(new Tuple<string, string>("forceDownloadService", this.Configuration.ApiClient.ParameterToString(forceDownloadService)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekSchedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WeekScheduleResponse>(localVarStatusCode,
                localVarHeaders,
                (WeekScheduleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WeekScheduleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>Task of WeekScheduleResponse</returns>
        public async System.Threading.Tasks.Task<WeekScheduleResponse> GetWorkforcemanagementManagementunitWeekScheduleAsync (string managementUnitId, string weekId, string scheduleId, string expand = null, bool? forceDownloadService = null)
        {
             ApiResponse<WeekScheduleResponse> localVarResponse = await GetWorkforcemanagementManagementunitWeekScheduleAsyncWithHttpInfo(managementUnitId, weekId, scheduleId, expand, forceDownloadService);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch</param>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ApiResponse (WeekScheduleResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WeekScheduleResponse>> GetWorkforcemanagementManagementunitWeekScheduleAsyncWithHttpInfo (string managementUnitId, string weekId, string scheduleId, string expand = null, bool? forceDownloadService = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekSchedule");
            
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekSchedule");
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekSchedule");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));
            if (scheduleId != null) localVarPathParams.Add("scheduleId", this.Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (forceDownloadService != null) localVarQueryParams.Add(new Tuple<string, string>("forceDownloadService", this.Configuration.ApiClient.ParameterToString(forceDownloadService)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekSchedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WeekScheduleResponse>(localVarStatusCode,
                localVarHeaders,
                (WeekScheduleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WeekScheduleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get week schedule generation results 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch generation results</param>
        /// <returns>WeekScheduleGenerationResult</returns>
        public WeekScheduleGenerationResult GetWorkforcemanagementManagementunitWeekScheduleGenerationresults (string managementUnitId, string weekId, string scheduleId)
        {
             ApiResponse<WeekScheduleGenerationResult> localVarResponse = GetWorkforcemanagementManagementunitWeekScheduleGenerationresultsWithHttpInfo(managementUnitId, weekId, scheduleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get week schedule generation results 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch generation results</param>
        /// <returns>ApiResponse of WeekScheduleGenerationResult</returns>
        public ApiResponse< WeekScheduleGenerationResult > GetWorkforcemanagementManagementunitWeekScheduleGenerationresultsWithHttpInfo (string managementUnitId, string weekId, string scheduleId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekScheduleGenerationresults");
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekScheduleGenerationresults");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekScheduleGenerationresults");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}/generationresults";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));
            if (scheduleId != null) localVarPathParams.Add("scheduleId", this.Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekScheduleGenerationresults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekScheduleGenerationresults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WeekScheduleGenerationResult>(localVarStatusCode,
                localVarHeaders,
                (WeekScheduleGenerationResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WeekScheduleGenerationResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get week schedule generation results 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch generation results</param>
        /// <returns>Task of WeekScheduleGenerationResult</returns>
        public async System.Threading.Tasks.Task<WeekScheduleGenerationResult> GetWorkforcemanagementManagementunitWeekScheduleGenerationresultsAsync (string managementUnitId, string weekId, string scheduleId)
        {
             ApiResponse<WeekScheduleGenerationResult> localVarResponse = await GetWorkforcemanagementManagementunitWeekScheduleGenerationresultsAsyncWithHttpInfo(managementUnitId, weekId, scheduleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get week schedule generation results 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to fetch generation results</param>
        /// <returns>Task of ApiResponse (WeekScheduleGenerationResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WeekScheduleGenerationResult>> GetWorkforcemanagementManagementunitWeekScheduleGenerationresultsAsyncWithHttpInfo (string managementUnitId, string weekId, string scheduleId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekScheduleGenerationresults");
            
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekScheduleGenerationresults");
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekScheduleGenerationresults");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}/generationresults";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));
            if (scheduleId != null) localVarPathParams.Add("scheduleId", this.Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekScheduleGenerationresults: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekScheduleGenerationresults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WeekScheduleGenerationResult>(localVarStatusCode,
                localVarHeaders,
                (WeekScheduleGenerationResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WeekScheduleGenerationResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get the list of schedules in a week in management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <returns>WeekScheduleListResponse</returns>
        public WeekScheduleListResponse GetWorkforcemanagementManagementunitWeekSchedules (string managementUnitId, string weekId)
        {
             ApiResponse<WeekScheduleListResponse> localVarResponse = GetWorkforcemanagementManagementunitWeekSchedulesWithHttpInfo(managementUnitId, weekId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of schedules in a week in management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <returns>ApiResponse of WeekScheduleListResponse</returns>
        public ApiResponse< WeekScheduleListResponse > GetWorkforcemanagementManagementunitWeekSchedulesWithHttpInfo (string managementUnitId, string weekId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekSchedules");
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekSchedules");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekSchedules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WeekScheduleListResponse>(localVarStatusCode,
                localVarHeaders,
                (WeekScheduleListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WeekScheduleListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get the list of schedules in a week in management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <returns>Task of WeekScheduleListResponse</returns>
        public async System.Threading.Tasks.Task<WeekScheduleListResponse> GetWorkforcemanagementManagementunitWeekSchedulesAsync (string managementUnitId, string weekId)
        {
             ApiResponse<WeekScheduleListResponse> localVarResponse = await GetWorkforcemanagementManagementunitWeekSchedulesAsyncWithHttpInfo(managementUnitId, weekId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of schedules in a week in management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <returns>Task of ApiResponse (WeekScheduleListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WeekScheduleListResponse>> GetWorkforcemanagementManagementunitWeekSchedulesAsyncWithHttpInfo (string managementUnitId, string weekId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekSchedules");
            
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekSchedules");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekSchedules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WeekScheduleListResponse>(localVarStatusCode,
                localVarHeaders,
                (WeekScheduleListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WeekScheduleListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get the final result of a short term forecast calculation with modifications applied 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>ForecastResultResponse</returns>
        public ForecastResultResponse GetWorkforcemanagementManagementunitWeekShorttermforecastFinal (string managementUnitId, string weekDateId, string forecastId, bool? forceDownloadService = null)
        {
             ApiResponse<ForecastResultResponse> localVarResponse = GetWorkforcemanagementManagementunitWeekShorttermforecastFinalWithHttpInfo(managementUnitId, weekDateId, forecastId, forceDownloadService);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the final result of a short term forecast calculation with modifications applied 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>ApiResponse of ForecastResultResponse</returns>
        public ApiResponse< ForecastResultResponse > GetWorkforcemanagementManagementunitWeekShorttermforecastFinalWithHttpInfo (string managementUnitId, string weekDateId, string forecastId, bool? forceDownloadService = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekShorttermforecastFinal");
            // verify the required parameter 'weekDateId' is set
            if (weekDateId == null)
                throw new ApiException(400, "Missing required parameter 'weekDateId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekShorttermforecastFinal");
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekShorttermforecastFinal");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/final";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekDateId != null) localVarPathParams.Add("weekDateId", this.Configuration.ApiClient.ParameterToString(weekDateId));
            if (forecastId != null) localVarPathParams.Add("forecastId", this.Configuration.ApiClient.ParameterToString(forecastId));

            // Query params
            if (forceDownloadService != null) localVarQueryParams.Add(new Tuple<string, string>("forceDownloadService", this.Configuration.ApiClient.ParameterToString(forceDownloadService)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekShorttermforecastFinal: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekShorttermforecastFinal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ForecastResultResponse>(localVarStatusCode,
                localVarHeaders,
                (ForecastResultResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ForecastResultResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get the final result of a short term forecast calculation with modifications applied 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ForecastResultResponse</returns>
        public async System.Threading.Tasks.Task<ForecastResultResponse> GetWorkforcemanagementManagementunitWeekShorttermforecastFinalAsync (string managementUnitId, string weekDateId, string forecastId, bool? forceDownloadService = null)
        {
             ApiResponse<ForecastResultResponse> localVarResponse = await GetWorkforcemanagementManagementunitWeekShorttermforecastFinalAsyncWithHttpInfo(managementUnitId, weekDateId, forecastId, forceDownloadService);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the final result of a short term forecast calculation with modifications applied 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ApiResponse (ForecastResultResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ForecastResultResponse>> GetWorkforcemanagementManagementunitWeekShorttermforecastFinalAsyncWithHttpInfo (string managementUnitId, string weekDateId, string forecastId, bool? forceDownloadService = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekShorttermforecastFinal");
            
            // verify the required parameter 'weekDateId' is set
            if (weekDateId == null)
                throw new ApiException(400, "Missing required parameter 'weekDateId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekShorttermforecastFinal");
            
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekShorttermforecastFinal");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/final";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekDateId != null) localVarPathParams.Add("weekDateId", this.Configuration.ApiClient.ParameterToString(weekDateId));
            if (forecastId != null) localVarPathParams.Add("forecastId", this.Configuration.ApiClient.ParameterToString(forecastId));

            // Query params
            if (forceDownloadService != null) localVarQueryParams.Add(new Tuple<string, string>("forceDownloadService", this.Configuration.ApiClient.ParameterToString(forceDownloadService)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekShorttermforecastFinal: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekShorttermforecastFinal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ForecastResultResponse>(localVarStatusCode,
                localVarHeaders,
                (ForecastResultResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ForecastResultResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get short term forecasts Use \&quot;recent\&quot; for the `weekDateId` path parameter to fetch all forecasts for +/- 26 weeks from the current date
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <returns>ShortTermForecastListResponse</returns>
        public ShortTermForecastListResponse GetWorkforcemanagementManagementunitWeekShorttermforecasts (string managementUnitId, string weekDateId)
        {
             ApiResponse<ShortTermForecastListResponse> localVarResponse = GetWorkforcemanagementManagementunitWeekShorttermforecastsWithHttpInfo(managementUnitId, weekDateId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get short term forecasts Use \&quot;recent\&quot; for the `weekDateId` path parameter to fetch all forecasts for +/- 26 weeks from the current date
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <returns>ApiResponse of ShortTermForecastListResponse</returns>
        public ApiResponse< ShortTermForecastListResponse > GetWorkforcemanagementManagementunitWeekShorttermforecastsWithHttpInfo (string managementUnitId, string weekDateId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekShorttermforecasts");
            // verify the required parameter 'weekDateId' is set
            if (weekDateId == null)
                throw new ApiException(400, "Missing required parameter 'weekDateId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekShorttermforecasts");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekDateId != null) localVarPathParams.Add("weekDateId", this.Configuration.ApiClient.ParameterToString(weekDateId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekShorttermforecasts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekShorttermforecasts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ShortTermForecastListResponse>(localVarStatusCode,
                localVarHeaders,
                (ShortTermForecastListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShortTermForecastListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get short term forecasts Use \&quot;recent\&quot; for the `weekDateId` path parameter to fetch all forecasts for +/- 26 weeks from the current date
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <returns>Task of ShortTermForecastListResponse</returns>
        public async System.Threading.Tasks.Task<ShortTermForecastListResponse> GetWorkforcemanagementManagementunitWeekShorttermforecastsAsync (string managementUnitId, string weekDateId)
        {
             ApiResponse<ShortTermForecastListResponse> localVarResponse = await GetWorkforcemanagementManagementunitWeekShorttermforecastsAsyncWithHttpInfo(managementUnitId, weekDateId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get short term forecasts Use \&quot;recent\&quot; for the `weekDateId` path parameter to fetch all forecasts for +/- 26 weeks from the current date
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <returns>Task of ApiResponse (ShortTermForecastListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ShortTermForecastListResponse>> GetWorkforcemanagementManagementunitWeekShorttermforecastsAsyncWithHttpInfo (string managementUnitId, string weekDateId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekShorttermforecasts");
            
            // verify the required parameter 'weekDateId' is set
            if (weekDateId == null)
                throw new ApiException(400, "Missing required parameter 'weekDateId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWeekShorttermforecasts");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekDateId != null) localVarPathParams.Add("weekDateId", this.Configuration.ApiClient.ParameterToString(weekDateId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekShorttermforecasts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWeekShorttermforecasts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ShortTermForecastListResponse>(localVarStatusCode,
                localVarHeaders,
                (ShortTermForecastListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShortTermForecastListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to fetch</param>
        /// <returns>WorkPlan</returns>
        public WorkPlan GetWorkforcemanagementManagementunitWorkplan (string managementUnitId, string workPlanId)
        {
             ApiResponse<WorkPlan> localVarResponse = GetWorkforcemanagementManagementunitWorkplanWithHttpInfo(managementUnitId, workPlanId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to fetch</param>
        /// <returns>ApiResponse of WorkPlan</returns>
        public ApiResponse< WorkPlan > GetWorkforcemanagementManagementunitWorkplanWithHttpInfo (string managementUnitId, string workPlanId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWorkplan");
            // verify the required parameter 'workPlanId' is set
            if (workPlanId == null)
                throw new ApiException(400, "Missing required parameter 'workPlanId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWorkplan");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (workPlanId != null) localVarPathParams.Add("workPlanId", this.Configuration.ApiClient.ParameterToString(workPlanId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWorkplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWorkplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkPlan>(localVarStatusCode,
                localVarHeaders,
                (WorkPlan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkPlan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to fetch</param>
        /// <returns>Task of WorkPlan</returns>
        public async System.Threading.Tasks.Task<WorkPlan> GetWorkforcemanagementManagementunitWorkplanAsync (string managementUnitId, string workPlanId)
        {
             ApiResponse<WorkPlan> localVarResponse = await GetWorkforcemanagementManagementunitWorkplanAsyncWithHttpInfo(managementUnitId, workPlanId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to fetch</param>
        /// <returns>Task of ApiResponse (WorkPlan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkPlan>> GetWorkforcemanagementManagementunitWorkplanAsyncWithHttpInfo (string managementUnitId, string workPlanId)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWorkplan");
            
            // verify the required parameter 'workPlanId' is set
            if (workPlanId == null)
                throw new ApiException(400, "Missing required parameter 'workPlanId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWorkplan");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (workPlanId != null) localVarPathParams.Add("workPlanId", this.Configuration.ApiClient.ParameterToString(workPlanId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWorkplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWorkplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkPlan>(localVarStatusCode,
                localVarHeaders,
                (WorkPlan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkPlan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get work plans 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>WorkPlanListResponse</returns>
        public WorkPlanListResponse GetWorkforcemanagementManagementunitWorkplans (string managementUnitId, List<string> expand = null)
        {
             ApiResponse<WorkPlanListResponse> localVarResponse = GetWorkforcemanagementManagementunitWorkplansWithHttpInfo(managementUnitId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get work plans 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>ApiResponse of WorkPlanListResponse</returns>
        public ApiResponse< WorkPlanListResponse > GetWorkforcemanagementManagementunitWorkplansWithHttpInfo (string managementUnitId, List<string> expand = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWorkplans");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWorkplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWorkplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkPlanListResponse>(localVarStatusCode,
                localVarHeaders,
                (WorkPlanListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkPlanListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get work plans 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>Task of WorkPlanListResponse</returns>
        public async System.Threading.Tasks.Task<WorkPlanListResponse> GetWorkforcemanagementManagementunitWorkplansAsync (string managementUnitId, List<string> expand = null)
        {
             ApiResponse<WorkPlanListResponse> localVarResponse = await GetWorkforcemanagementManagementunitWorkplansAsyncWithHttpInfo(managementUnitId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get work plans 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="expand"> (optional)</param>
        /// <returns>Task of ApiResponse (WorkPlanListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkPlanListResponse>> GetWorkforcemanagementManagementunitWorkplansAsyncWithHttpInfo (string managementUnitId, List<string> expand = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->GetWorkforcemanagementManagementunitWorkplans");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWorkplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitWorkplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkPlanListResponse>(localVarStatusCode,
                localVarHeaders,
                (WorkPlanListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkPlanListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>ManagementUnitListing</returns>
        public ManagementUnitListing GetWorkforcemanagementManagementunits (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null)
        {
             ApiResponse<ManagementUnitListing> localVarResponse = GetWorkforcemanagementManagementunitsWithHttpInfo(pageSize, pageNumber, expand, feature, divisionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>ApiResponse of ManagementUnitListing</returns>
        public ApiResponse< ManagementUnitListing > GetWorkforcemanagementManagementunitsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/managementunits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (feature != null) localVarQueryParams.Add(new Tuple<string, string>("feature", this.Configuration.ApiClient.ParameterToString(feature)));
            if (divisionId != null) localVarQueryParams.Add(new Tuple<string, string>("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnitListing>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnitListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnitListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>Task of ManagementUnitListing</returns>
        public async System.Threading.Tasks.Task<ManagementUnitListing> GetWorkforcemanagementManagementunitsAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null)
        {
             ApiResponse<ManagementUnitListing> localVarResponse = await GetWorkforcemanagementManagementunitsAsyncWithHttpInfo(pageSize, pageNumber, expand, feature, divisionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="pageNumber"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="feature"> (optional)</param>
        /// <param name="divisionId"> (optional)</param>
        /// <returns>Task of ApiResponse (ManagementUnitListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagementUnitListing>> GetWorkforcemanagementManagementunitsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/managementunits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (expand != null) localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(expand)));
            if (feature != null) localVarQueryParams.Add(new Tuple<string, string>("feature", this.Configuration.ApiClient.ParameterToString(feature)));
            if (divisionId != null) localVarQueryParams.Add(new Tuple<string, string>("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnitListing>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnitListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnitListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get management units across divisions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">The divisionIds to filter by. If omitted, will return all divisions (optional)</param>
        /// <returns>ManagementUnitListing</returns>
        public ManagementUnitListing GetWorkforcemanagementManagementunitsDivisionviews (List<string> divisionId = null)
        {
             ApiResponse<ManagementUnitListing> localVarResponse = GetWorkforcemanagementManagementunitsDivisionviewsWithHttpInfo(divisionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get management units across divisions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">The divisionIds to filter by. If omitted, will return all divisions (optional)</param>
        /// <returns>ApiResponse of ManagementUnitListing</returns>
        public ApiResponse< ManagementUnitListing > GetWorkforcemanagementManagementunitsDivisionviewsWithHttpInfo (List<string> divisionId = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/managementunits/divisionviews";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (divisionId != null) divisionId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("divisionId", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitsDivisionviews: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitsDivisionviews: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnitListing>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnitListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnitListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get management units across divisions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">The divisionIds to filter by. If omitted, will return all divisions (optional)</param>
        /// <returns>Task of ManagementUnitListing</returns>
        public async System.Threading.Tasks.Task<ManagementUnitListing> GetWorkforcemanagementManagementunitsDivisionviewsAsync (List<string> divisionId = null)
        {
             ApiResponse<ManagementUnitListing> localVarResponse = await GetWorkforcemanagementManagementunitsDivisionviewsAsyncWithHttpInfo(divisionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get management units across divisions 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">The divisionIds to filter by. If omitted, will return all divisions (optional)</param>
        /// <returns>Task of ApiResponse (ManagementUnitListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagementUnitListing>> GetWorkforcemanagementManagementunitsDivisionviewsAsyncWithHttpInfo (List<string> divisionId = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/managementunits/divisionviews";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (divisionId != null) divisionId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("divisionId", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitsDivisionviews: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementManagementunitsDivisionviews: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnitListing>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnitListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnitListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a time off request for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>TimeOffRequestResponse</returns>
        public TimeOffRequestResponse GetWorkforcemanagementTimeoffrequest (string timeOffRequestId)
        {
             ApiResponse<TimeOffRequestResponse> localVarResponse = GetWorkforcemanagementTimeoffrequestWithHttpInfo(timeOffRequestId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a time off request for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>ApiResponse of TimeOffRequestResponse</returns>
        public ApiResponse< TimeOffRequestResponse > GetWorkforcemanagementTimeoffrequestWithHttpInfo (string timeOffRequestId)
        { 
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->GetWorkforcemanagementTimeoffrequest");

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", this.Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestResponse>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a time off request for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of TimeOffRequestResponse</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestResponse> GetWorkforcemanagementTimeoffrequestAsync (string timeOffRequestId)
        {
             ApiResponse<TimeOffRequestResponse> localVarResponse = await GetWorkforcemanagementTimeoffrequestAsyncWithHttpInfo(timeOffRequestId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a time off request for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <returns>Task of ApiResponse (TimeOffRequestResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestResponse>> GetWorkforcemanagementTimeoffrequestAsyncWithHttpInfo (string timeOffRequestId)
        { 
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->GetWorkforcemanagementTimeoffrequest");
            

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", this.Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestResponse>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of time off requests for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>TimeOffRequestList</returns>
        public TimeOffRequestList GetWorkforcemanagementTimeoffrequests (bool? recentlyReviewed = null)
        {
             ApiResponse<TimeOffRequestList> localVarResponse = GetWorkforcemanagementTimeoffrequestsWithHttpInfo(recentlyReviewed);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of time off requests for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>ApiResponse of TimeOffRequestList</returns>
        public ApiResponse< TimeOffRequestList > GetWorkforcemanagementTimeoffrequestsWithHttpInfo (bool? recentlyReviewed = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (recentlyReviewed != null) localVarQueryParams.Add(new Tuple<string, string>("recentlyReviewed", this.Configuration.ApiClient.ParameterToString(recentlyReviewed)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of time off requests for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of TimeOffRequestList</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestList> GetWorkforcemanagementTimeoffrequestsAsync (bool? recentlyReviewed = null)
        {
             ApiResponse<TimeOffRequestList> localVarResponse = await GetWorkforcemanagementTimeoffrequestsAsyncWithHttpInfo(recentlyReviewed);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of time off requests for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recentlyReviewed">Limit results to requests that have been reviewed within the preceding 30 days (optional, default to false)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestList>> GetWorkforcemanagementTimeoffrequestsAsyncWithHttpInfo (bool? recentlyReviewed = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (recentlyReviewed != null) localVarQueryParams.Add(new Tuple<string, string>("recentlyReviewed", this.Configuration.ApiClient.ParameterToString(recentlyReviewed)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkforcemanagementTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update an activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ActivityCode</returns>
        public ActivityCode PatchWorkforcemanagementManagementunitActivitycode (string muId, string acId, UpdateActivityCodeRequest body = null)
        {
             ApiResponse<ActivityCode> localVarResponse = PatchWorkforcemanagementManagementunitActivitycodeWithHttpInfo(muId, acId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of ActivityCode</returns>
        public ApiResponse< ActivityCode > PatchWorkforcemanagementManagementunitActivitycodeWithHttpInfo (string muId, string acId, UpdateActivityCodeRequest body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitActivitycode");
            // verify the required parameter 'acId' is set
            if (acId == null)
                throw new ApiException(400, "Missing required parameter 'acId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitActivitycode");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/activitycodes/{acId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (acId != null) localVarPathParams.Add("acId", this.Configuration.ApiClient.ParameterToString(acId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitActivitycode: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitActivitycode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActivityCode>(localVarStatusCode,
                localVarHeaders,
                (ActivityCode) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCode)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update an activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ActivityCode</returns>
        public async System.Threading.Tasks.Task<ActivityCode> PatchWorkforcemanagementManagementunitActivitycodeAsync (string muId, string acId, UpdateActivityCodeRequest body = null)
        {
             ApiResponse<ActivityCode> localVarResponse = await PatchWorkforcemanagementManagementunitActivitycodeAsyncWithHttpInfo(muId, acId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="acId">The ID of the activity code to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (ActivityCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ActivityCode>> PatchWorkforcemanagementManagementunitActivitycodeAsyncWithHttpInfo (string muId, string acId, UpdateActivityCodeRequest body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitActivitycode");
            
            // verify the required parameter 'acId' is set
            if (acId == null)
                throw new ApiException(400, "Missing required parameter 'acId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitActivitycode");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/activitycodes/{acId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (acId != null) localVarPathParams.Add("acId", this.Configuration.ApiClient.ParameterToString(acId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitActivitycode: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitActivitycode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActivityCode>(localVarStatusCode,
                localVarHeaders,
                (ActivityCode) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCode)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Marks a specific scheduling run as applied, allowing a new rescheduling run to be started 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <param name="body">body (optional)</param>
        /// <returns>RescheduleResult</returns>
        public RescheduleResult PatchWorkforcemanagementManagementunitSchedulingRun (string managementUnitId, string runId, UpdateSchedulingRunRequest body = null)
        {
             ApiResponse<RescheduleResult> localVarResponse = PatchWorkforcemanagementManagementunitSchedulingRunWithHttpInfo(managementUnitId, runId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Marks a specific scheduling run as applied, allowing a new rescheduling run to be started 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of RescheduleResult</returns>
        public ApiResponse< RescheduleResult > PatchWorkforcemanagementManagementunitSchedulingRunWithHttpInfo (string managementUnitId, string runId, UpdateSchedulingRunRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitSchedulingRun");
            // verify the required parameter 'runId' is set
            if (runId == null)
                throw new ApiException(400, "Missing required parameter 'runId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitSchedulingRun");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (runId != null) localVarPathParams.Add("runId", this.Configuration.ApiClient.ParameterToString(runId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitSchedulingRun: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitSchedulingRun: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RescheduleResult>(localVarStatusCode,
                localVarHeaders,
                (RescheduleResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RescheduleResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Marks a specific scheduling run as applied, allowing a new rescheduling run to be started 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of RescheduleResult</returns>
        public async System.Threading.Tasks.Task<RescheduleResult> PatchWorkforcemanagementManagementunitSchedulingRunAsync (string managementUnitId, string runId, UpdateSchedulingRunRequest body = null)
        {
             ApiResponse<RescheduleResult> localVarResponse = await PatchWorkforcemanagementManagementunitSchedulingRunAsyncWithHttpInfo(managementUnitId, runId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Marks a specific scheduling run as applied, allowing a new rescheduling run to be started 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit.</param>
        /// <param name="runId">The ID of the schedule run</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (RescheduleResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RescheduleResult>> PatchWorkforcemanagementManagementunitSchedulingRunAsyncWithHttpInfo (string managementUnitId, string runId, UpdateSchedulingRunRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitSchedulingRun");
            
            // verify the required parameter 'runId' is set
            if (runId == null)
                throw new ApiException(400, "Missing required parameter 'runId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitSchedulingRun");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/scheduling/runs/{runId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (runId != null) localVarPathParams.Add("runId", this.Configuration.ApiClient.ParameterToString(runId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitSchedulingRun: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitSchedulingRun: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RescheduleResult>(localVarStatusCode,
                localVarHeaders,
                (RescheduleResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RescheduleResult)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update a service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ServiceGoalGroup</returns>
        public ServiceGoalGroup PatchWorkforcemanagementManagementunitServicegoalgroup (string managementUnitId, string serviceGoalGroupId, ServiceGoalGroup body = null)
        {
             ApiResponse<ServiceGoalGroup> localVarResponse = PatchWorkforcemanagementManagementunitServicegoalgroupWithHttpInfo(managementUnitId, serviceGoalGroupId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of ServiceGoalGroup</returns>
        public ApiResponse< ServiceGoalGroup > PatchWorkforcemanagementManagementunitServicegoalgroupWithHttpInfo (string managementUnitId, string serviceGoalGroupId, ServiceGoalGroup body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitServicegoalgroup");
            // verify the required parameter 'serviceGoalGroupId' is set
            if (serviceGoalGroupId == null)
                throw new ApiException(400, "Missing required parameter 'serviceGoalGroupId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitServicegoalgroup");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups/{serviceGoalGroupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (serviceGoalGroupId != null) localVarPathParams.Add("serviceGoalGroupId", this.Configuration.ApiClient.ParameterToString(serviceGoalGroupId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitServicegoalgroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitServicegoalgroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ServiceGoalGroup>(localVarStatusCode,
                localVarHeaders,
                (ServiceGoalGroup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceGoalGroup)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update a service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ServiceGoalGroup</returns>
        public async System.Threading.Tasks.Task<ServiceGoalGroup> PatchWorkforcemanagementManagementunitServicegoalgroupAsync (string managementUnitId, string serviceGoalGroupId, ServiceGoalGroup body = null)
        {
             ApiResponse<ServiceGoalGroup> localVarResponse = await PatchWorkforcemanagementManagementunitServicegoalgroupAsyncWithHttpInfo(managementUnitId, serviceGoalGroupId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="serviceGoalGroupId">The ID of the service goal group to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (ServiceGoalGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServiceGoalGroup>> PatchWorkforcemanagementManagementunitServicegoalgroupAsyncWithHttpInfo (string managementUnitId, string serviceGoalGroupId, ServiceGoalGroup body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitServicegoalgroup");
            
            // verify the required parameter 'serviceGoalGroupId' is set
            if (serviceGoalGroupId == null)
                throw new ApiException(400, "Missing required parameter 'serviceGoalGroupId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitServicegoalgroup");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups/{serviceGoalGroupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (serviceGoalGroupId != null) localVarPathParams.Add("serviceGoalGroupId", this.Configuration.ApiClient.ParameterToString(serviceGoalGroupId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitServicegoalgroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitServicegoalgroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ServiceGoalGroup>(localVarStatusCode,
                localVarHeaders,
                (ServiceGoalGroup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceGoalGroup)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Patch the settings for the requested management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">config (optional)</param>
        /// <returns>ManagementUnitSettings</returns>
        public ManagementUnitSettings PatchWorkforcemanagementManagementunitSettings (string muId, ManagementUnitSettings body = null)
        {
             ApiResponse<ManagementUnitSettings> localVarResponse = PatchWorkforcemanagementManagementunitSettingsWithHttpInfo(muId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch the settings for the requested management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">config (optional)</param>
        /// <returns>ApiResponse of ManagementUnitSettings</returns>
        public ApiResponse< ManagementUnitSettings > PatchWorkforcemanagementManagementunitSettingsWithHttpInfo (string muId, ManagementUnitSettings body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitSettings");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnitSettings>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnitSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnitSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Patch the settings for the requested management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">config (optional)</param>
        /// <returns>Task of ManagementUnitSettings</returns>
        public async System.Threading.Tasks.Task<ManagementUnitSettings> PatchWorkforcemanagementManagementunitSettingsAsync (string muId, ManagementUnitSettings body = null)
        {
             ApiResponse<ManagementUnitSettings> localVarResponse = await PatchWorkforcemanagementManagementunitSettingsAsyncWithHttpInfo(muId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch the settings for the requested management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">config (optional)</param>
        /// <returns>Task of ApiResponse (ManagementUnitSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagementUnitSettings>> PatchWorkforcemanagementManagementunitSettingsAsyncWithHttpInfo (string muId, ManagementUnitSettings body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitSettings");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnitSettings>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnitSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnitSettings)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>TimeOffRequestResponse</returns>
        public TimeOffRequestResponse PatchWorkforcemanagementManagementunitUserTimeoffrequest (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null)
        {
             ApiResponse<TimeOffRequestResponse> localVarResponse = PatchWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo(muId, userId, timeOffRequestId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of TimeOffRequestResponse</returns>
        public ApiResponse< TimeOffRequestResponse > PatchWorkforcemanagementManagementunitUserTimeoffrequestWithHttpInfo (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitUserTimeoffrequest");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitUserTimeoffrequest");
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitUserTimeoffrequest");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", this.Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestResponse>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of TimeOffRequestResponse</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestResponse> PatchWorkforcemanagementManagementunitUserTimeoffrequestAsync (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null)
        {
             ApiResponse<TimeOffRequestResponse> localVarResponse = await PatchWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo(muId, userId, timeOffRequestId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="userId">The id of the user the requested time off request belongs to</param>
        /// <param name="timeOffRequestId">The id of the time off request to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestResponse>> PatchWorkforcemanagementManagementunitUserTimeoffrequestAsyncWithHttpInfo (string muId, string userId, string timeOffRequestId, AdminTimeOffRequestPatch body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitUserTimeoffrequest");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitUserTimeoffrequest");
            
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitUserTimeoffrequest");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/users/{userId}/timeoffrequests/{timeOffRequestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", this.Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitUserTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestResponse>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to update. Use partial uploads of user schedules if activity count in schedule is greater than 17500</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>AsyncWeekScheduleResponse</returns>
        public AsyncWeekScheduleResponse PatchWorkforcemanagementManagementunitWeekSchedule (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, UpdateWeekScheduleRequest body = null)
        {
             ApiResponse<AsyncWeekScheduleResponse> localVarResponse = PatchWorkforcemanagementManagementunitWeekScheduleWithHttpInfo(managementUnitId, weekId, scheduleId, forceAsync, forceDownloadService, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to update. Use partial uploads of user schedules if activity count in schedule is greater than 17500</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of AsyncWeekScheduleResponse</returns>
        public ApiResponse< AsyncWeekScheduleResponse > PatchWorkforcemanagementManagementunitWeekScheduleWithHttpInfo (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, UpdateWeekScheduleRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitWeekSchedule");
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitWeekSchedule");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitWeekSchedule");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));
            if (scheduleId != null) localVarPathParams.Add("scheduleId", this.Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params
            if (forceAsync != null) localVarQueryParams.Add(new Tuple<string, string>("forceAsync", this.Configuration.ApiClient.ParameterToString(forceAsync)));
            if (forceDownloadService != null) localVarQueryParams.Add(new Tuple<string, string>("forceDownloadService", this.Configuration.ApiClient.ParameterToString(forceDownloadService)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitWeekSchedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitWeekSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncWeekScheduleResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncWeekScheduleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncWeekScheduleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to update. Use partial uploads of user schedules if activity count in schedule is greater than 17500</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of AsyncWeekScheduleResponse</returns>
        public async System.Threading.Tasks.Task<AsyncWeekScheduleResponse> PatchWorkforcemanagementManagementunitWeekScheduleAsync (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, UpdateWeekScheduleRequest body = null)
        {
             ApiResponse<AsyncWeekScheduleResponse> localVarResponse = await PatchWorkforcemanagementManagementunitWeekScheduleAsyncWithHttpInfo(managementUnitId, weekId, scheduleId, forceAsync, forceDownloadService, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to update. Use partial uploads of user schedules if activity count in schedule is greater than 17500</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (AsyncWeekScheduleResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncWeekScheduleResponse>> PatchWorkforcemanagementManagementunitWeekScheduleAsyncWithHttpInfo (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, UpdateWeekScheduleRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitWeekSchedule");
            
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitWeekSchedule");
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitWeekSchedule");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));
            if (scheduleId != null) localVarPathParams.Add("scheduleId", this.Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params
            if (forceAsync != null) localVarQueryParams.Add(new Tuple<string, string>("forceAsync", this.Configuration.ApiClient.ParameterToString(forceAsync)));
            if (forceDownloadService != null) localVarQueryParams.Add(new Tuple<string, string>("forceDownloadService", this.Configuration.ApiClient.ParameterToString(forceDownloadService)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitWeekSchedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitWeekSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncWeekScheduleResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncWeekScheduleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncWeekScheduleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update a work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>WorkPlan</returns>
        public WorkPlan PatchWorkforcemanagementManagementunitWorkplan (string managementUnitId, string workPlanId, WorkPlan body = null)
        {
             ApiResponse<WorkPlan> localVarResponse = PatchWorkforcemanagementManagementunitWorkplanWithHttpInfo(managementUnitId, workPlanId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WorkPlan</returns>
        public ApiResponse< WorkPlan > PatchWorkforcemanagementManagementunitWorkplanWithHttpInfo (string managementUnitId, string workPlanId, WorkPlan body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitWorkplan");
            // verify the required parameter 'workPlanId' is set
            if (workPlanId == null)
                throw new ApiException(400, "Missing required parameter 'workPlanId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitWorkplan");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (workPlanId != null) localVarPathParams.Add("workPlanId", this.Configuration.ApiClient.ParameterToString(workPlanId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitWorkplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitWorkplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkPlan>(localVarStatusCode,
                localVarHeaders,
                (WorkPlan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkPlan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update a work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WorkPlan</returns>
        public async System.Threading.Tasks.Task<WorkPlan> PatchWorkforcemanagementManagementunitWorkplanAsync (string managementUnitId, string workPlanId, WorkPlan body = null)
        {
             ApiResponse<WorkPlan> localVarResponse = await PatchWorkforcemanagementManagementunitWorkplanAsyncWithHttpInfo(managementUnitId, workPlanId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to update</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WorkPlan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkPlan>> PatchWorkforcemanagementManagementunitWorkplanAsyncWithHttpInfo (string managementUnitId, string workPlanId, WorkPlan body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitWorkplan");
            
            // verify the required parameter 'workPlanId' is set
            if (workPlanId == null)
                throw new ApiException(400, "Missing required parameter 'workPlanId' when calling WorkforceManagementApi->PatchWorkforcemanagementManagementunitWorkplan");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (workPlanId != null) localVarPathParams.Add("workPlanId", this.Configuration.ApiClient.ParameterToString(workPlanId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitWorkplan: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementManagementunitWorkplan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkPlan>(localVarStatusCode,
                localVarHeaders,
                (WorkPlan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkPlan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update a time off request for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>TimeOffRequestResponse</returns>
        public TimeOffRequestResponse PatchWorkforcemanagementTimeoffrequest (string timeOffRequestId, AgentTimeOffRequestPatch body = null)
        {
             ApiResponse<TimeOffRequestResponse> localVarResponse = PatchWorkforcemanagementTimeoffrequestWithHttpInfo(timeOffRequestId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a time off request for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of TimeOffRequestResponse</returns>
        public ApiResponse< TimeOffRequestResponse > PatchWorkforcemanagementTimeoffrequestWithHttpInfo (string timeOffRequestId, AgentTimeOffRequestPatch body = null)
        { 
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->PatchWorkforcemanagementTimeoffrequest");

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", this.Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestResponse>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update a time off request for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of TimeOffRequestResponse</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestResponse> PatchWorkforcemanagementTimeoffrequestAsync (string timeOffRequestId, AgentTimeOffRequestPatch body = null)
        {
             ApiResponse<TimeOffRequestResponse> localVarResponse = await PatchWorkforcemanagementTimeoffrequestAsyncWithHttpInfo(timeOffRequestId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a time off request for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeOffRequestId">Time Off Request Id</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestResponse>> PatchWorkforcemanagementTimeoffrequestAsyncWithHttpInfo (string timeOffRequestId, AgentTimeOffRequestPatch body = null)
        { 
            // verify the required parameter 'timeOffRequestId' is set
            if (timeOffRequestId == null)
                throw new ApiException(400, "Missing required parameter 'timeOffRequestId' when calling WorkforceManagementApi->PatchWorkforcemanagementTimeoffrequest");
            

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests/{timeOffRequestId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (timeOffRequestId != null) localVarPathParams.Add("timeOffRequestId", this.Configuration.ApiClient.ParameterToString(timeOffRequestId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementTimeoffrequest: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchWorkforcemanagementTimeoffrequest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestResponse>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Request a historical adherence report for users across management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>WfmHistoricalAdherenceResponse</returns>
        public WfmHistoricalAdherenceResponse PostWorkforcemanagementAdherenceHistorical (WfmHistoricalAdherenceQueryForUsers body = null)
        {
             ApiResponse<WfmHistoricalAdherenceResponse> localVarResponse = PostWorkforcemanagementAdherenceHistoricalWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Request a historical adherence report for users across management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WfmHistoricalAdherenceResponse</returns>
        public ApiResponse< WfmHistoricalAdherenceResponse > PostWorkforcemanagementAdherenceHistoricalWithHttpInfo (WfmHistoricalAdherenceQueryForUsers body = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/adherence/historical";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementAdherenceHistorical: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementAdherenceHistorical: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmHistoricalAdherenceResponse>(localVarStatusCode,
                localVarHeaders,
                (WfmHistoricalAdherenceResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmHistoricalAdherenceResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Request a historical adherence report for users across management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WfmHistoricalAdherenceResponse</returns>
        public async System.Threading.Tasks.Task<WfmHistoricalAdherenceResponse> PostWorkforcemanagementAdherenceHistoricalAsync (WfmHistoricalAdherenceQueryForUsers body = null)
        {
             ApiResponse<WfmHistoricalAdherenceResponse> localVarResponse = await PostWorkforcemanagementAdherenceHistoricalAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Request a historical adherence report for users across management units 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WfmHistoricalAdherenceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WfmHistoricalAdherenceResponse>> PostWorkforcemanagementAdherenceHistoricalAsyncWithHttpInfo (WfmHistoricalAdherenceQueryForUsers body = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/adherence/historical";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementAdherenceHistorical: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementAdherenceHistorical: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmHistoricalAdherenceResponse>(localVarStatusCode,
                localVarHeaders,
                (WfmHistoricalAdherenceResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmHistoricalAdherenceResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create a new activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ActivityCode</returns>
        public ActivityCode PostWorkforcemanagementManagementunitActivitycodes (string muId, CreateActivityCodeRequest body = null)
        {
             ApiResponse<ActivityCode> localVarResponse = PostWorkforcemanagementManagementunitActivitycodesWithHttpInfo(muId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of ActivityCode</returns>
        public ApiResponse< ActivityCode > PostWorkforcemanagementManagementunitActivitycodesWithHttpInfo (string muId, CreateActivityCodeRequest body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitActivitycodes");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/activitycodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActivityCode>(localVarStatusCode,
                localVarHeaders,
                (ActivityCode) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCode)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create a new activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ActivityCode</returns>
        public async System.Threading.Tasks.Task<ActivityCode> PostWorkforcemanagementManagementunitActivitycodesAsync (string muId, CreateActivityCodeRequest body = null)
        {
             ApiResponse<ActivityCode> localVarResponse = await PostWorkforcemanagementManagementunitActivitycodesAsyncWithHttpInfo(muId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new activity code 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (ActivityCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ActivityCode>> PostWorkforcemanagementManagementunitActivitycodesAsyncWithHttpInfo (string muId, CreateActivityCodeRequest body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitActivitycodes");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/activitycodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitActivitycodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ActivityCode>(localVarStatusCode,
                localVarHeaders,
                (ActivityCode) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCode)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Request a historical adherence report The maximum supported range for historical adherence queries is 31 days, or 7 days with includeExceptions = true
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>WfmHistoricalAdherenceResponse</returns>
        public WfmHistoricalAdherenceResponse PostWorkforcemanagementManagementunitHistoricaladherencequery (string muId, WfmHistoricalAdherenceQuery body = null)
        {
             ApiResponse<WfmHistoricalAdherenceResponse> localVarResponse = PostWorkforcemanagementManagementunitHistoricaladherencequeryWithHttpInfo(muId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Request a historical adherence report The maximum supported range for historical adherence queries is 31 days, or 7 days with includeExceptions = true
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WfmHistoricalAdherenceResponse</returns>
        public ApiResponse< WfmHistoricalAdherenceResponse > PostWorkforcemanagementManagementunitHistoricaladherencequeryWithHttpInfo (string muId, WfmHistoricalAdherenceQuery body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitHistoricaladherencequery");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/historicaladherencequery";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitHistoricaladherencequery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitHistoricaladherencequery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmHistoricalAdherenceResponse>(localVarStatusCode,
                localVarHeaders,
                (WfmHistoricalAdherenceResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmHistoricalAdherenceResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Request a historical adherence report The maximum supported range for historical adherence queries is 31 days, or 7 days with includeExceptions = true
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WfmHistoricalAdherenceResponse</returns>
        public async System.Threading.Tasks.Task<WfmHistoricalAdherenceResponse> PostWorkforcemanagementManagementunitHistoricaladherencequeryAsync (string muId, WfmHistoricalAdherenceQuery body = null)
        {
             ApiResponse<WfmHistoricalAdherenceResponse> localVarResponse = await PostWorkforcemanagementManagementunitHistoricaladherencequeryAsyncWithHttpInfo(muId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Request a historical adherence report The maximum supported range for historical adherence queries is 31 days, or 7 days with includeExceptions = true
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WfmHistoricalAdherenceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WfmHistoricalAdherenceResponse>> PostWorkforcemanagementManagementunitHistoricaladherencequeryAsyncWithHttpInfo (string muId, WfmHistoricalAdherenceQuery body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitHistoricaladherencequery");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/historicaladherencequery";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitHistoricaladherencequery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitHistoricaladherencequery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WfmHistoricalAdherenceResponse>(localVarStatusCode,
                localVarHeaders,
                (WfmHistoricalAdherenceResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WfmHistoricalAdherenceResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get intraday data for the given date for the requested queueIds 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>IntradayResponse</returns>
        public IntradayResponse PostWorkforcemanagementManagementunitIntraday (string muId, IntradayQueryDataCommand body = null)
        {
             ApiResponse<IntradayResponse> localVarResponse = PostWorkforcemanagementManagementunitIntradayWithHttpInfo(muId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get intraday data for the given date for the requested queueIds 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of IntradayResponse</returns>
        public ApiResponse< IntradayResponse > PostWorkforcemanagementManagementunitIntradayWithHttpInfo (string muId, IntradayQueryDataCommand body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitIntraday");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/intraday";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitIntraday: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitIntraday: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntradayResponse>(localVarStatusCode,
                localVarHeaders,
                (IntradayResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntradayResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get intraday data for the given date for the requested queueIds 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of IntradayResponse</returns>
        public async System.Threading.Tasks.Task<IntradayResponse> PostWorkforcemanagementManagementunitIntradayAsync (string muId, IntradayQueryDataCommand body = null)
        {
             ApiResponse<IntradayResponse> localVarResponse = await PostWorkforcemanagementManagementunitIntradayAsyncWithHttpInfo(muId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get intraday data for the given date for the requested queueIds 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (IntradayResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntradayResponse>> PostWorkforcemanagementManagementunitIntradayAsyncWithHttpInfo (string muId, IntradayQueryDataCommand body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitIntraday");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/intraday";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitIntraday: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitIntraday: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntradayResponse>(localVarStatusCode,
                localVarHeaders,
                (IntradayResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntradayResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Query published schedules for given given time range for set of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>UserScheduleContainer</returns>
        public UserScheduleContainer PostWorkforcemanagementManagementunitSchedulesSearch (string muId, UserListScheduleRequestBody body = null)
        {
             ApiResponse<UserScheduleContainer> localVarResponse = PostWorkforcemanagementManagementunitSchedulesSearchWithHttpInfo(muId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query published schedules for given given time range for set of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of UserScheduleContainer</returns>
        public ApiResponse< UserScheduleContainer > PostWorkforcemanagementManagementunitSchedulesSearchWithHttpInfo (string muId, UserListScheduleRequestBody body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitSchedulesSearch");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/schedules/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitSchedulesSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitSchedulesSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserScheduleContainer>(localVarStatusCode,
                localVarHeaders,
                (UserScheduleContainer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserScheduleContainer)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Query published schedules for given given time range for set of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of UserScheduleContainer</returns>
        public async System.Threading.Tasks.Task<UserScheduleContainer> PostWorkforcemanagementManagementunitSchedulesSearchAsync (string muId, UserListScheduleRequestBody body = null)
        {
             ApiResponse<UserScheduleContainer> localVarResponse = await PostWorkforcemanagementManagementunitSchedulesSearchAsyncWithHttpInfo(muId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query published schedules for given given time range for set of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The management unit ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (UserScheduleContainer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserScheduleContainer>> PostWorkforcemanagementManagementunitSchedulesSearchAsyncWithHttpInfo (string muId, UserListScheduleRequestBody body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitSchedulesSearch");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/schedules/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitSchedulesSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitSchedulesSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserScheduleContainer>(localVarStatusCode,
                localVarHeaders,
                (UserScheduleContainer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserScheduleContainer)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create a new service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ServiceGoalGroup</returns>
        public ServiceGoalGroup PostWorkforcemanagementManagementunitServicegoalgroups (string managementUnitId, CreateServiceGoalGroupRequest body = null)
        {
             ApiResponse<ServiceGoalGroup> localVarResponse = PostWorkforcemanagementManagementunitServicegoalgroupsWithHttpInfo(managementUnitId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of ServiceGoalGroup</returns>
        public ApiResponse< ServiceGoalGroup > PostWorkforcemanagementManagementunitServicegoalgroupsWithHttpInfo (string managementUnitId, CreateServiceGoalGroupRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitServicegoalgroups");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitServicegoalgroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitServicegoalgroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ServiceGoalGroup>(localVarStatusCode,
                localVarHeaders,
                (ServiceGoalGroup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceGoalGroup)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create a new service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ServiceGoalGroup</returns>
        public async System.Threading.Tasks.Task<ServiceGoalGroup> PostWorkforcemanagementManagementunitServicegoalgroupsAsync (string managementUnitId, CreateServiceGoalGroupRequest body = null)
        {
             ApiResponse<ServiceGoalGroup> localVarResponse = await PostWorkforcemanagementManagementunitServicegoalgroupsAsyncWithHttpInfo(managementUnitId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new service goal group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (ServiceGoalGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServiceGoalGroup>> PostWorkforcemanagementManagementunitServicegoalgroupsAsyncWithHttpInfo (string managementUnitId, CreateServiceGoalGroupRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitServicegoalgroups");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/servicegoalgroups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitServicegoalgroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitServicegoalgroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ServiceGoalGroup>(localVarStatusCode,
                localVarHeaders,
                (ServiceGoalGroup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceGoalGroup)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create a new time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>TimeOffRequestList</returns>
        public TimeOffRequestList PostWorkforcemanagementManagementunitTimeoffrequests (string muId, CreateAdminTimeOffRequest body = null)
        {
             ApiResponse<TimeOffRequestList> localVarResponse = PostWorkforcemanagementManagementunitTimeoffrequestsWithHttpInfo(muId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of TimeOffRequestList</returns>
        public ApiResponse< TimeOffRequestList > PostWorkforcemanagementManagementunitTimeoffrequestsWithHttpInfo (string muId, CreateAdminTimeOffRequest body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitTimeoffrequests");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/timeoffrequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create a new time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of TimeOffRequestList</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestList> PostWorkforcemanagementManagementunitTimeoffrequestsAsync (string muId, CreateAdminTimeOffRequest body = null)
        {
             ApiResponse<TimeOffRequestList> localVarResponse = await PostWorkforcemanagementManagementunitTimeoffrequestsAsyncWithHttpInfo(muId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new time off request 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestList>> PostWorkforcemanagementManagementunitTimeoffrequestsAsyncWithHttpInfo (string muId, CreateAdminTimeOffRequest body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitTimeoffrequests");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/timeoffrequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Gets a list of time off requests from lookup ids 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>TimeOffRequestEntityList</returns>
        public TimeOffRequestEntityList PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails (string muId, TimeOffRequestLookupList body = null)
        {
             ApiResponse<TimeOffRequestEntityList> localVarResponse = PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetailsWithHttpInfo(muId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of time off requests from lookup ids 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of TimeOffRequestEntityList</returns>
        public ApiResponse< TimeOffRequestEntityList > PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetailsWithHttpInfo (string muId, TimeOffRequestLookupList body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/timeoffrequests/fetchdetails";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestEntityList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestEntityList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestEntityList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Gets a list of time off requests from lookup ids 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of TimeOffRequestEntityList</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestEntityList> PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetailsAsync (string muId, TimeOffRequestLookupList body = null)
        {
             ApiResponse<TimeOffRequestEntityList> localVarResponse = await PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetailsAsyncWithHttpInfo(muId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a list of time off requests from lookup ids 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestEntityList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestEntityList>> PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetailsAsyncWithHttpInfo (string muId, TimeOffRequestLookupList body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/timeoffrequests/fetchdetails";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitTimeoffrequestsFetchdetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestEntityList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestEntityList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestEntityList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Gets the lookup ids to fetch the specified set of requests 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>TimeOffRequestLookupList</returns>
        public TimeOffRequestLookupList PostWorkforcemanagementManagementunitTimeoffrequestsQuery (string muId, TimeOffRequestQueryBody body = null)
        {
             ApiResponse<TimeOffRequestLookupList> localVarResponse = PostWorkforcemanagementManagementunitTimeoffrequestsQueryWithHttpInfo(muId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the lookup ids to fetch the specified set of requests 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of TimeOffRequestLookupList</returns>
        public ApiResponse< TimeOffRequestLookupList > PostWorkforcemanagementManagementunitTimeoffrequestsQueryWithHttpInfo (string muId, TimeOffRequestQueryBody body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitTimeoffrequestsQuery");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/timeoffrequests/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitTimeoffrequestsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitTimeoffrequestsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestLookupList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestLookupList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestLookupList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Gets the lookup ids to fetch the specified set of requests 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of TimeOffRequestLookupList</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestLookupList> PostWorkforcemanagementManagementunitTimeoffrequestsQueryAsync (string muId, TimeOffRequestQueryBody body = null)
        {
             ApiResponse<TimeOffRequestLookupList> localVarResponse = await PostWorkforcemanagementManagementunitTimeoffrequestsQueryAsyncWithHttpInfo(muId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the lookup ids to fetch the specified set of requests 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muId">The muId of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestLookupList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestLookupList>> PostWorkforcemanagementManagementunitTimeoffrequestsQueryAsyncWithHttpInfo (string muId, TimeOffRequestQueryBody body = null)
        { 
            // verify the required parameter 'muId' is set
            if (muId == null)
                throw new ApiException(400, "Missing required parameter 'muId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitTimeoffrequestsQuery");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{muId}/timeoffrequests/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (muId != null) localVarPathParams.Add("muId", this.Configuration.ApiClient.ParameterToString(muId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitTimeoffrequestsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitTimeoffrequestsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestLookupList>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestLookupList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestLookupList)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Copy a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to copy from</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>AsyncWeekScheduleResponse</returns>
        public AsyncWeekScheduleResponse PostWorkforcemanagementManagementunitWeekScheduleCopy (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, CopyWeekScheduleRequest body = null)
        {
             ApiResponse<AsyncWeekScheduleResponse> localVarResponse = PostWorkforcemanagementManagementunitWeekScheduleCopyWithHttpInfo(managementUnitId, weekId, scheduleId, forceAsync, forceDownloadService, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Copy a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to copy from</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of AsyncWeekScheduleResponse</returns>
        public ApiResponse< AsyncWeekScheduleResponse > PostWorkforcemanagementManagementunitWeekScheduleCopyWithHttpInfo (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, CopyWeekScheduleRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekScheduleCopy");
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekScheduleCopy");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekScheduleCopy");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}/copy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));
            if (scheduleId != null) localVarPathParams.Add("scheduleId", this.Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params
            if (forceAsync != null) localVarQueryParams.Add(new Tuple<string, string>("forceAsync", this.Configuration.ApiClient.ParameterToString(forceAsync)));
            if (forceDownloadService != null) localVarQueryParams.Add(new Tuple<string, string>("forceDownloadService", this.Configuration.ApiClient.ParameterToString(forceDownloadService)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekScheduleCopy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekScheduleCopy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncWeekScheduleResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncWeekScheduleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncWeekScheduleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Copy a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to copy from</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of AsyncWeekScheduleResponse</returns>
        public async System.Threading.Tasks.Task<AsyncWeekScheduleResponse> PostWorkforcemanagementManagementunitWeekScheduleCopyAsync (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, CopyWeekScheduleRequest body = null)
        {
             ApiResponse<AsyncWeekScheduleResponse> localVarResponse = await PostWorkforcemanagementManagementunitWeekScheduleCopyAsyncWithHttpInfo(managementUnitId, weekId, scheduleId, forceAsync, forceDownloadService, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Copy a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to copy from</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (AsyncWeekScheduleResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncWeekScheduleResponse>> PostWorkforcemanagementManagementunitWeekScheduleCopyAsyncWithHttpInfo (string managementUnitId, string weekId, string scheduleId, bool? forceAsync = null, bool? forceDownloadService = null, CopyWeekScheduleRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekScheduleCopy");
            
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekScheduleCopy");
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekScheduleCopy");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}/copy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));
            if (scheduleId != null) localVarPathParams.Add("scheduleId", this.Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params
            if (forceAsync != null) localVarQueryParams.Add(new Tuple<string, string>("forceAsync", this.Configuration.ApiClient.ParameterToString(forceAsync)));
            if (forceDownloadService != null) localVarQueryParams.Add(new Tuple<string, string>("forceDownloadService", this.Configuration.ApiClient.ParameterToString(forceDownloadService)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekScheduleCopy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekScheduleCopy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncWeekScheduleResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncWeekScheduleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncWeekScheduleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Start a scheduling run to compute the reschedule. When the scheduling run finishes, a client can get the reschedule changes and then the client can apply them to the schedule, save the schedule, and mark the scheduling run as applied 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to re-optimize</param>
        /// <param name="body">body (optional)</param>
        /// <returns>AsyncWeekScheduleResponse</returns>
        public AsyncWeekScheduleResponse PostWorkforcemanagementManagementunitWeekScheduleReschedule (string managementUnitId, string weekId, string scheduleId, RescheduleRequest body = null)
        {
             ApiResponse<AsyncWeekScheduleResponse> localVarResponse = PostWorkforcemanagementManagementunitWeekScheduleRescheduleWithHttpInfo(managementUnitId, weekId, scheduleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Start a scheduling run to compute the reschedule. When the scheduling run finishes, a client can get the reschedule changes and then the client can apply them to the schedule, save the schedule, and mark the scheduling run as applied 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to re-optimize</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of AsyncWeekScheduleResponse</returns>
        public ApiResponse< AsyncWeekScheduleResponse > PostWorkforcemanagementManagementunitWeekScheduleRescheduleWithHttpInfo (string managementUnitId, string weekId, string scheduleId, RescheduleRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekScheduleReschedule");
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekScheduleReschedule");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekScheduleReschedule");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}/reschedule";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));
            if (scheduleId != null) localVarPathParams.Add("scheduleId", this.Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekScheduleReschedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekScheduleReschedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncWeekScheduleResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncWeekScheduleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncWeekScheduleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Start a scheduling run to compute the reschedule. When the scheduling run finishes, a client can get the reschedule changes and then the client can apply them to the schedule, save the schedule, and mark the scheduling run as applied 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to re-optimize</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of AsyncWeekScheduleResponse</returns>
        public async System.Threading.Tasks.Task<AsyncWeekScheduleResponse> PostWorkforcemanagementManagementunitWeekScheduleRescheduleAsync (string managementUnitId, string weekId, string scheduleId, RescheduleRequest body = null)
        {
             ApiResponse<AsyncWeekScheduleResponse> localVarResponse = await PostWorkforcemanagementManagementunitWeekScheduleRescheduleAsyncWithHttpInfo(managementUnitId, weekId, scheduleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Start a scheduling run to compute the reschedule. When the scheduling run finishes, a client can get the reschedule changes and then the client can apply them to the schedule, save the schedule, and mark the scheduling run as applied 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="scheduleId">The ID of the schedule to re-optimize</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (AsyncWeekScheduleResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncWeekScheduleResponse>> PostWorkforcemanagementManagementunitWeekScheduleRescheduleAsyncWithHttpInfo (string managementUnitId, string weekId, string scheduleId, RescheduleRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekScheduleReschedule");
            
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekScheduleReschedule");
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekScheduleReschedule");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/{scheduleId}/reschedule";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));
            if (scheduleId != null) localVarPathParams.Add("scheduleId", this.Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekScheduleReschedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekScheduleReschedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncWeekScheduleResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncWeekScheduleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncWeekScheduleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Add a schedule for a week in management unit using imported data. Use partial uploads of user schedules if activity count in schedule is greater than 17500 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>AsyncWeekScheduleResponse</returns>
        public AsyncWeekScheduleResponse PostWorkforcemanagementManagementunitWeekSchedules (string managementUnitId, string weekId, bool? forceAsync = null, bool? forceDownloadService = null, ImportWeekScheduleRequest body = null)
        {
             ApiResponse<AsyncWeekScheduleResponse> localVarResponse = PostWorkforcemanagementManagementunitWeekSchedulesWithHttpInfo(managementUnitId, weekId, forceAsync, forceDownloadService, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a schedule for a week in management unit using imported data. Use partial uploads of user schedules if activity count in schedule is greater than 17500 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of AsyncWeekScheduleResponse</returns>
        public ApiResponse< AsyncWeekScheduleResponse > PostWorkforcemanagementManagementunitWeekSchedulesWithHttpInfo (string managementUnitId, string weekId, bool? forceAsync = null, bool? forceDownloadService = null, ImportWeekScheduleRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekSchedules");
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekSchedules");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));

            // Query params
            if (forceAsync != null) localVarQueryParams.Add(new Tuple<string, string>("forceAsync", this.Configuration.ApiClient.ParameterToString(forceAsync)));
            if (forceDownloadService != null) localVarQueryParams.Add(new Tuple<string, string>("forceDownloadService", this.Configuration.ApiClient.ParameterToString(forceDownloadService)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekSchedules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncWeekScheduleResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncWeekScheduleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncWeekScheduleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Add a schedule for a week in management unit using imported data. Use partial uploads of user schedules if activity count in schedule is greater than 17500 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of AsyncWeekScheduleResponse</returns>
        public async System.Threading.Tasks.Task<AsyncWeekScheduleResponse> PostWorkforcemanagementManagementunitWeekSchedulesAsync (string managementUnitId, string weekId, bool? forceAsync = null, bool? forceDownloadService = null, ImportWeekScheduleRequest body = null)
        {
             ApiResponse<AsyncWeekScheduleResponse> localVarResponse = await PostWorkforcemanagementManagementunitWeekSchedulesAsyncWithHttpInfo(managementUnitId, weekId, forceAsync, forceDownloadService, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a schedule for a week in management unit using imported data. Use partial uploads of user schedules if activity count in schedule is greater than 17500 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <param name="forceDownloadService">Force the result of this operation to be sent via download service.  For testing/app development purposes (optional)</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (AsyncWeekScheduleResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncWeekScheduleResponse>> PostWorkforcemanagementManagementunitWeekSchedulesAsyncWithHttpInfo (string managementUnitId, string weekId, bool? forceAsync = null, bool? forceDownloadService = null, ImportWeekScheduleRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekSchedules");
            
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekSchedules");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));

            // Query params
            if (forceAsync != null) localVarQueryParams.Add(new Tuple<string, string>("forceAsync", this.Configuration.ApiClient.ParameterToString(forceAsync)));
            if (forceDownloadService != null) localVarQueryParams.Add(new Tuple<string, string>("forceDownloadService", this.Configuration.ApiClient.ParameterToString(forceDownloadService)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekSchedules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncWeekScheduleResponse>(localVarStatusCode,
                localVarHeaders,
                (AsyncWeekScheduleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncWeekScheduleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Generate a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>GenerateWeekScheduleResponse</returns>
        public GenerateWeekScheduleResponse PostWorkforcemanagementManagementunitWeekSchedulesGenerate (string managementUnitId, string weekId, GenerateWeekScheduleRequest body = null)
        {
             ApiResponse<GenerateWeekScheduleResponse> localVarResponse = PostWorkforcemanagementManagementunitWeekSchedulesGenerateWithHttpInfo(managementUnitId, weekId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of GenerateWeekScheduleResponse</returns>
        public ApiResponse< GenerateWeekScheduleResponse > PostWorkforcemanagementManagementunitWeekSchedulesGenerateWithHttpInfo (string managementUnitId, string weekId, GenerateWeekScheduleRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekSchedulesGenerate");
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekSchedulesGenerate");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/generate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekSchedulesGenerate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekSchedulesGenerate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GenerateWeekScheduleResponse>(localVarStatusCode,
                localVarHeaders,
                (GenerateWeekScheduleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GenerateWeekScheduleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Generate a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of GenerateWeekScheduleResponse</returns>
        public async System.Threading.Tasks.Task<GenerateWeekScheduleResponse> PostWorkforcemanagementManagementunitWeekSchedulesGenerateAsync (string managementUnitId, string weekId, GenerateWeekScheduleRequest body = null)
        {
             ApiResponse<GenerateWeekScheduleResponse> localVarResponse = await PostWorkforcemanagementManagementunitWeekSchedulesGenerateAsyncWithHttpInfo(managementUnitId, weekId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate a week schedule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (GenerateWeekScheduleResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GenerateWeekScheduleResponse>> PostWorkforcemanagementManagementunitWeekSchedulesGenerateAsyncWithHttpInfo (string managementUnitId, string weekId, GenerateWeekScheduleRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekSchedulesGenerate");
            
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekSchedulesGenerate");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/generate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekSchedulesGenerate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekSchedulesGenerate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GenerateWeekScheduleResponse>(localVarStatusCode,
                localVarHeaders,
                (GenerateWeekScheduleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GenerateWeekScheduleResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Partial upload of user schedules where activity count is greater than 17500 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>PartialUploadResponse</returns>
        public PartialUploadResponse PostWorkforcemanagementManagementunitWeekSchedulesPartialupload (string managementUnitId, string weekId, UserSchedulesPartialUploadRequest body = null)
        {
             ApiResponse<PartialUploadResponse> localVarResponse = PostWorkforcemanagementManagementunitWeekSchedulesPartialuploadWithHttpInfo(managementUnitId, weekId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Partial upload of user schedules where activity count is greater than 17500 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of PartialUploadResponse</returns>
        public ApiResponse< PartialUploadResponse > PostWorkforcemanagementManagementunitWeekSchedulesPartialuploadWithHttpInfo (string managementUnitId, string weekId, UserSchedulesPartialUploadRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekSchedulesPartialupload");
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekSchedulesPartialupload");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/partialupload";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekSchedulesPartialupload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekSchedulesPartialupload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PartialUploadResponse>(localVarStatusCode,
                localVarHeaders,
                (PartialUploadResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PartialUploadResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Partial upload of user schedules where activity count is greater than 17500 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of PartialUploadResponse</returns>
        public async System.Threading.Tasks.Task<PartialUploadResponse> PostWorkforcemanagementManagementunitWeekSchedulesPartialuploadAsync (string managementUnitId, string weekId, UserSchedulesPartialUploadRequest body = null)
        {
             ApiResponse<PartialUploadResponse> localVarResponse = await PostWorkforcemanagementManagementunitWeekSchedulesPartialuploadAsyncWithHttpInfo(managementUnitId, weekId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Partial upload of user schedules where activity count is greater than 17500 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="weekId">First day of schedule week in yyyy-MM-dd format.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (PartialUploadResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PartialUploadResponse>> PostWorkforcemanagementManagementunitWeekSchedulesPartialuploadAsyncWithHttpInfo (string managementUnitId, string weekId, UserSchedulesPartialUploadRequest body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekSchedulesPartialupload");
            
            // verify the required parameter 'weekId' is set
            if (weekId == null)
                throw new ApiException(400, "Missing required parameter 'weekId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekSchedulesPartialupload");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekId}/schedules/partialupload";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekId != null) localVarPathParams.Add("weekId", this.Configuration.ApiClient.ParameterToString(weekId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekSchedulesPartialupload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekSchedulesPartialupload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PartialUploadResponse>(localVarStatusCode,
                localVarHeaders,
                (PartialUploadResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PartialUploadResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Copy a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast to copy</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>ShortTermForecastResponse</returns>
        public ShortTermForecastResponse PostWorkforcemanagementManagementunitWeekShorttermforecastCopy (string managementUnitId, string weekDateId, string forecastId, CopyShortTermForecastRequest body, bool? forceAsync = null)
        {
             ApiResponse<ShortTermForecastResponse> localVarResponse = PostWorkforcemanagementManagementunitWeekShorttermforecastCopyWithHttpInfo(managementUnitId, weekDateId, forecastId, body, forceAsync);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Copy a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast to copy</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>ApiResponse of ShortTermForecastResponse</returns>
        public ApiResponse< ShortTermForecastResponse > PostWorkforcemanagementManagementunitWeekShorttermforecastCopyWithHttpInfo (string managementUnitId, string weekDateId, string forecastId, CopyShortTermForecastRequest body, bool? forceAsync = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastCopy");
            // verify the required parameter 'weekDateId' is set
            if (weekDateId == null)
                throw new ApiException(400, "Missing required parameter 'weekDateId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastCopy");
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastCopy");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastCopy");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/copy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekDateId != null) localVarPathParams.Add("weekDateId", this.Configuration.ApiClient.ParameterToString(weekDateId));
            if (forecastId != null) localVarPathParams.Add("forecastId", this.Configuration.ApiClient.ParameterToString(forecastId));

            // Query params
            if (forceAsync != null) localVarQueryParams.Add(new Tuple<string, string>("forceAsync", this.Configuration.ApiClient.ParameterToString(forceAsync)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecastCopy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecastCopy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ShortTermForecastResponse>(localVarStatusCode,
                localVarHeaders,
                (ShortTermForecastResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShortTermForecastResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Copy a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast to copy</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ShortTermForecastResponse</returns>
        public async System.Threading.Tasks.Task<ShortTermForecastResponse> PostWorkforcemanagementManagementunitWeekShorttermforecastCopyAsync (string managementUnitId, string weekDateId, string forecastId, CopyShortTermForecastRequest body, bool? forceAsync = null)
        {
             ApiResponse<ShortTermForecastResponse> localVarResponse = await PostWorkforcemanagementManagementunitWeekShorttermforecastCopyAsyncWithHttpInfo(managementUnitId, weekDateId, forecastId, body, forceAsync);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Copy a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="forecastId">The ID of the forecast to copy</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ApiResponse (ShortTermForecastResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ShortTermForecastResponse>> PostWorkforcemanagementManagementunitWeekShorttermforecastCopyAsyncWithHttpInfo (string managementUnitId, string weekDateId, string forecastId, CopyShortTermForecastRequest body, bool? forceAsync = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastCopy");
            
            // verify the required parameter 'weekDateId' is set
            if (weekDateId == null)
                throw new ApiException(400, "Missing required parameter 'weekDateId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastCopy");
            
            // verify the required parameter 'forecastId' is set
            if (forecastId == null)
                throw new ApiException(400, "Missing required parameter 'forecastId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastCopy");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastCopy");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/{forecastId}/copy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekDateId != null) localVarPathParams.Add("weekDateId", this.Configuration.ApiClient.ParameterToString(weekDateId));
            if (forecastId != null) localVarPathParams.Add("forecastId", this.Configuration.ApiClient.ParameterToString(forecastId));

            // Query params
            if (forceAsync != null) localVarQueryParams.Add(new Tuple<string, string>("forceAsync", this.Configuration.ApiClient.ParameterToString(forceAsync)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecastCopy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecastCopy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ShortTermForecastResponse>(localVarStatusCode,
                localVarHeaders,
                (ShortTermForecastResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShortTermForecastResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Import a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>ShortTermForecastResponse</returns>
        public ShortTermForecastResponse PostWorkforcemanagementManagementunitWeekShorttermforecasts (string managementUnitId, string weekDateId, ImportShortTermForecastRequest body, bool? forceAsync = null)
        {
             ApiResponse<ShortTermForecastResponse> localVarResponse = PostWorkforcemanagementManagementunitWeekShorttermforecastsWithHttpInfo(managementUnitId, weekDateId, body, forceAsync);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Import a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>ApiResponse of ShortTermForecastResponse</returns>
        public ApiResponse< ShortTermForecastResponse > PostWorkforcemanagementManagementunitWeekShorttermforecastsWithHttpInfo (string managementUnitId, string weekDateId, ImportShortTermForecastRequest body, bool? forceAsync = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecasts");
            // verify the required parameter 'weekDateId' is set
            if (weekDateId == null)
                throw new ApiException(400, "Missing required parameter 'weekDateId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecasts");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecasts");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekDateId != null) localVarPathParams.Add("weekDateId", this.Configuration.ApiClient.ParameterToString(weekDateId));

            // Query params
            if (forceAsync != null) localVarQueryParams.Add(new Tuple<string, string>("forceAsync", this.Configuration.ApiClient.ParameterToString(forceAsync)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecasts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecasts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ShortTermForecastResponse>(localVarStatusCode,
                localVarHeaders,
                (ShortTermForecastResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShortTermForecastResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Import a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ShortTermForecastResponse</returns>
        public async System.Threading.Tasks.Task<ShortTermForecastResponse> PostWorkforcemanagementManagementunitWeekShorttermforecastsAsync (string managementUnitId, string weekDateId, ImportShortTermForecastRequest body, bool? forceAsync = null)
        {
             ApiResponse<ShortTermForecastResponse> localVarResponse = await PostWorkforcemanagementManagementunitWeekShorttermforecastsAsyncWithHttpInfo(managementUnitId, weekDateId, body, forceAsync);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Import a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ApiResponse (ShortTermForecastResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ShortTermForecastResponse>> PostWorkforcemanagementManagementunitWeekShorttermforecastsAsyncWithHttpInfo (string managementUnitId, string weekDateId, ImportShortTermForecastRequest body, bool? forceAsync = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecasts");
            
            // verify the required parameter 'weekDateId' is set
            if (weekDateId == null)
                throw new ApiException(400, "Missing required parameter 'weekDateId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecasts");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecasts");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekDateId != null) localVarPathParams.Add("weekDateId", this.Configuration.ApiClient.ParameterToString(weekDateId));

            // Query params
            if (forceAsync != null) localVarQueryParams.Add(new Tuple<string, string>("forceAsync", this.Configuration.ApiClient.ParameterToString(forceAsync)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecasts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecasts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ShortTermForecastResponse>(localVarStatusCode,
                localVarHeaders,
                (ShortTermForecastResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShortTermForecastResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Generate a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body"></param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>GenerateShortTermForecastResponse</returns>
        public GenerateShortTermForecastResponse PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate (string managementUnitId, string weekDateId, GenerateShortTermForecastRequest body, bool? forceAsync = null)
        {
             ApiResponse<GenerateShortTermForecastResponse> localVarResponse = PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerateWithHttpInfo(managementUnitId, weekDateId, body, forceAsync);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body"></param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>ApiResponse of GenerateShortTermForecastResponse</returns>
        public ApiResponse< GenerateShortTermForecastResponse > PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerateWithHttpInfo (string managementUnitId, string weekDateId, GenerateShortTermForecastRequest body, bool? forceAsync = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate");
            // verify the required parameter 'weekDateId' is set
            if (weekDateId == null)
                throw new ApiException(400, "Missing required parameter 'weekDateId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/generate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekDateId != null) localVarPathParams.Add("weekDateId", this.Configuration.ApiClient.ParameterToString(weekDateId));

            // Query params
            if (forceAsync != null) localVarQueryParams.Add(new Tuple<string, string>("forceAsync", this.Configuration.ApiClient.ParameterToString(forceAsync)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GenerateShortTermForecastResponse>(localVarStatusCode,
                localVarHeaders,
                (GenerateShortTermForecastResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GenerateShortTermForecastResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Generate a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body"></param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>Task of GenerateShortTermForecastResponse</returns>
        public async System.Threading.Tasks.Task<GenerateShortTermForecastResponse> PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerateAsync (string managementUnitId, string weekDateId, GenerateShortTermForecastRequest body, bool? forceAsync = null)
        {
             ApiResponse<GenerateShortTermForecastResponse> localVarResponse = await PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerateAsyncWithHttpInfo(managementUnitId, weekDateId, body, forceAsync);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body"></param>
        /// <param name="forceAsync">Force the result of this operation to be sent asynchronously via notification.  For testing/app development purposes (optional)</param>
        /// <returns>Task of ApiResponse (GenerateShortTermForecastResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GenerateShortTermForecastResponse>> PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerateAsyncWithHttpInfo (string managementUnitId, string weekDateId, GenerateShortTermForecastRequest body, bool? forceAsync = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate");
            
            // verify the required parameter 'weekDateId' is set
            if (weekDateId == null)
                throw new ApiException(400, "Missing required parameter 'weekDateId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/generate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekDateId != null) localVarPathParams.Add("weekDateId", this.Configuration.ApiClient.ParameterToString(weekDateId));

            // Query params
            if (forceAsync != null) localVarQueryParams.Add(new Tuple<string, string>("forceAsync", this.Configuration.ApiClient.ParameterToString(forceAsync)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecastsGenerate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GenerateShortTermForecastResponse>(localVarStatusCode,
                localVarHeaders,
                (GenerateShortTermForecastResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GenerateShortTermForecastResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Import a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <returns>PartialUploadResponse</returns>
        public PartialUploadResponse PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload (string managementUnitId, string weekDateId, RouteGroupList body)
        {
             ApiResponse<PartialUploadResponse> localVarResponse = PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialuploadWithHttpInfo(managementUnitId, weekDateId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Import a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <returns>ApiResponse of PartialUploadResponse</returns>
        public ApiResponse< PartialUploadResponse > PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialuploadWithHttpInfo (string managementUnitId, string weekDateId, RouteGroupList body)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload");
            // verify the required parameter 'weekDateId' is set
            if (weekDateId == null)
                throw new ApiException(400, "Missing required parameter 'weekDateId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/partialupload";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekDateId != null) localVarPathParams.Add("weekDateId", this.Configuration.ApiClient.ParameterToString(weekDateId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PartialUploadResponse>(localVarStatusCode,
                localVarHeaders,
                (PartialUploadResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PartialUploadResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Import a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <returns>Task of PartialUploadResponse</returns>
        public async System.Threading.Tasks.Task<PartialUploadResponse> PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialuploadAsync (string managementUnitId, string weekDateId, RouteGroupList body)
        {
             ApiResponse<PartialUploadResponse> localVarResponse = await PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialuploadAsyncWithHttpInfo(managementUnitId, weekDateId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Import a short term forecast 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The management unit ID of the management unit to which the forecast belongs</param>
        /// <param name="weekDateId">The week start date of the forecast in yyyy-MM-dd format</param>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse (PartialUploadResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PartialUploadResponse>> PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialuploadAsyncWithHttpInfo (string managementUnitId, string weekDateId, RouteGroupList body)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload");
            
            // verify the required parameter 'weekDateId' is set
            if (weekDateId == null)
                throw new ApiException(400, "Missing required parameter 'weekDateId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/weeks/{weekDateId}/shorttermforecasts/partialupload";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (weekDateId != null) localVarPathParams.Add("weekDateId", this.Configuration.ApiClient.ParameterToString(weekDateId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWeekShorttermforecastsPartialupload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PartialUploadResponse>(localVarStatusCode,
                localVarHeaders,
                (PartialUploadResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PartialUploadResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create a copy of work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to create a copy</param>
        /// <param name="body">body (optional)</param>
        /// <returns>WorkPlan</returns>
        public WorkPlan PostWorkforcemanagementManagementunitWorkplanCopy (string managementUnitId, string workPlanId, CopyWorkPlan body = null)
        {
             ApiResponse<WorkPlan> localVarResponse = PostWorkforcemanagementManagementunitWorkplanCopyWithHttpInfo(managementUnitId, workPlanId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a copy of work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to create a copy</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WorkPlan</returns>
        public ApiResponse< WorkPlan > PostWorkforcemanagementManagementunitWorkplanCopyWithHttpInfo (string managementUnitId, string workPlanId, CopyWorkPlan body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWorkplanCopy");
            // verify the required parameter 'workPlanId' is set
            if (workPlanId == null)
                throw new ApiException(400, "Missing required parameter 'workPlanId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWorkplanCopy");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}/copy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (workPlanId != null) localVarPathParams.Add("workPlanId", this.Configuration.ApiClient.ParameterToString(workPlanId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWorkplanCopy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWorkplanCopy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkPlan>(localVarStatusCode,
                localVarHeaders,
                (WorkPlan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkPlan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create a copy of work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to create a copy</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WorkPlan</returns>
        public async System.Threading.Tasks.Task<WorkPlan> PostWorkforcemanagementManagementunitWorkplanCopyAsync (string managementUnitId, string workPlanId, CopyWorkPlan body = null)
        {
             ApiResponse<WorkPlan> localVarResponse = await PostWorkforcemanagementManagementunitWorkplanCopyAsyncWithHttpInfo(managementUnitId, workPlanId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a copy of work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="workPlanId">The ID of the work plan to create a copy</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WorkPlan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkPlan>> PostWorkforcemanagementManagementunitWorkplanCopyAsyncWithHttpInfo (string managementUnitId, string workPlanId, CopyWorkPlan body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWorkplanCopy");
            
            // verify the required parameter 'workPlanId' is set
            if (workPlanId == null)
                throw new ApiException(400, "Missing required parameter 'workPlanId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWorkplanCopy");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans/{workPlanId}/copy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));
            if (workPlanId != null) localVarPathParams.Add("workPlanId", this.Configuration.ApiClient.ParameterToString(workPlanId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWorkplanCopy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWorkplanCopy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkPlan>(localVarStatusCode,
                localVarHeaders,
                (WorkPlan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkPlan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create a new work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>WorkPlan</returns>
        public WorkPlan PostWorkforcemanagementManagementunitWorkplans (string managementUnitId, CreateWorkPlan body = null)
        {
             ApiResponse<WorkPlan> localVarResponse = PostWorkforcemanagementManagementunitWorkplansWithHttpInfo(managementUnitId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of WorkPlan</returns>
        public ApiResponse< WorkPlan > PostWorkforcemanagementManagementunitWorkplansWithHttpInfo (string managementUnitId, CreateWorkPlan body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWorkplans");

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWorkplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWorkplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkPlan>(localVarStatusCode,
                localVarHeaders,
                (WorkPlan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkPlan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create a new work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of WorkPlan</returns>
        public async System.Threading.Tasks.Task<WorkPlan> PostWorkforcemanagementManagementunitWorkplansAsync (string managementUnitId, CreateWorkPlan body = null)
        {
             ApiResponse<WorkPlan> localVarResponse = await PostWorkforcemanagementManagementunitWorkplansAsyncWithHttpInfo(managementUnitId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new work plan 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="managementUnitId">The ID of the management unit, or &#39;mine&#39; for the management unit of the logged-in user.</param>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (WorkPlan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkPlan>> PostWorkforcemanagementManagementunitWorkplansAsyncWithHttpInfo (string managementUnitId, CreateWorkPlan body = null)
        { 
            // verify the required parameter 'managementUnitId' is set
            if (managementUnitId == null)
                throw new ApiException(400, "Missing required parameter 'managementUnitId' when calling WorkforceManagementApi->PostWorkforcemanagementManagementunitWorkplans");
            

            var localVarPath = "/api/v2/workforcemanagement/managementunits/{managementUnitId}/workplans";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (managementUnitId != null) localVarPathParams.Add("managementUnitId", this.Configuration.ApiClient.ParameterToString(managementUnitId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWorkplans: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunitWorkplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkPlan>(localVarStatusCode,
                localVarHeaders,
                (WorkPlan) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkPlan)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Add a management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ManagementUnit</returns>
        public ManagementUnit PostWorkforcemanagementManagementunits (CreateManagementUnitApiRequest body = null)
        {
             ApiResponse<ManagementUnit> localVarResponse = PostWorkforcemanagementManagementunitsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of ManagementUnit</returns>
        public ApiResponse< ManagementUnit > PostWorkforcemanagementManagementunitsWithHttpInfo (CreateManagementUnitApiRequest body = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/managementunits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnit>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnit) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnit)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Add a management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ManagementUnit</returns>
        public async System.Threading.Tasks.Task<ManagementUnit> PostWorkforcemanagementManagementunitsAsync (CreateManagementUnitApiRequest body = null)
        {
             ApiResponse<ManagementUnit> localVarResponse = await PostWorkforcemanagementManagementunitsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a management unit 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (ManagementUnit)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagementUnit>> PostWorkforcemanagementManagementunitsAsyncWithHttpInfo (CreateManagementUnitApiRequest body = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/managementunits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementManagementunits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ManagementUnit>(localVarStatusCode,
                localVarHeaders,
                (ManagementUnit) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagementUnit)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get published schedule for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>UserScheduleContainer</returns>
        public UserScheduleContainer PostWorkforcemanagementSchedules (CurrentUserScheduleRequestBody body = null)
        {
             ApiResponse<UserScheduleContainer> localVarResponse = PostWorkforcemanagementSchedulesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get published schedule for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of UserScheduleContainer</returns>
        public ApiResponse< UserScheduleContainer > PostWorkforcemanagementSchedulesWithHttpInfo (CurrentUserScheduleRequestBody body = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/schedules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementSchedules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserScheduleContainer>(localVarStatusCode,
                localVarHeaders,
                (UserScheduleContainer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserScheduleContainer)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get published schedule for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of UserScheduleContainer</returns>
        public async System.Threading.Tasks.Task<UserScheduleContainer> PostWorkforcemanagementSchedulesAsync (CurrentUserScheduleRequestBody body = null)
        {
             ApiResponse<UserScheduleContainer> localVarResponse = await PostWorkforcemanagementSchedulesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get published schedule for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (UserScheduleContainer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserScheduleContainer>> PostWorkforcemanagementSchedulesAsyncWithHttpInfo (CurrentUserScheduleRequestBody body = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/schedules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementSchedules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserScheduleContainer>(localVarStatusCode,
                localVarHeaders,
                (UserScheduleContainer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserScheduleContainer)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create a time off request for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>TimeOffRequestResponse</returns>
        public TimeOffRequestResponse PostWorkforcemanagementTimeoffrequests (CreateAgentTimeOffRequest body = null)
        {
             ApiResponse<TimeOffRequestResponse> localVarResponse = PostWorkforcemanagementTimeoffrequestsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a time off request for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>ApiResponse of TimeOffRequestResponse</returns>
        public ApiResponse< TimeOffRequestResponse > PostWorkforcemanagementTimeoffrequestsWithHttpInfo (CreateAgentTimeOffRequest body = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestResponse>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create a time off request for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of TimeOffRequestResponse</returns>
        public async System.Threading.Tasks.Task<TimeOffRequestResponse> PostWorkforcemanagementTimeoffrequestsAsync (CreateAgentTimeOffRequest body = null)
        {
             ApiResponse<TimeOffRequestResponse> localVarResponse = await PostWorkforcemanagementTimeoffrequestsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a time off request for the current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">body (optional)</param>
        /// <returns>Task of ApiResponse (TimeOffRequestResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeOffRequestResponse>> PostWorkforcemanagementTimeoffrequestsAsyncWithHttpInfo (CreateAgentTimeOffRequest body = null)
        { 

            var localVarPath = "/api/v2/workforcemanagement/timeoffrequests";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementTimeoffrequests: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWorkforcemanagementTimeoffrequests: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimeOffRequestResponse>(localVarStatusCode,
                localVarHeaders,
                (TimeOffRequestResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimeOffRequestResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
