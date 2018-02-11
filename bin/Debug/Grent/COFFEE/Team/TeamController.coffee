
BaseController = require("./../../base/BaseController.coffee")
TeamModel = require("./TeamModel.coffee")



TeamController = cc.coffee.BaseControllerExtend.extend(

    ctor:(_model)->
        @_super(this, _model)
        _model.SetNewLeaderNotifyCB(@NewLeaderCBNotify)
        _model.SetDissmissTeamNotifyNotifyCB(@DissmissTeamNotifyCBNotify)
        _model.SetJoinTeamNotifyNotifyCB(@JoinTeamNotifyCBNotify)
        _model.SetKickMemberNotifyNotifyCB(@KickMemberNotifyCBNotify)
        _model.SetLeaveTeamNotifyNotifyCB(@LeaveTeamNotifyCBNotify)
        _model.SetApplyTeamNotifyNotifyCB(@ApplyTeamNotifyCBNotify)
        _model.SetAgreeApplicantNotifyNotifyCB(@AgreeApplicantNotifyCBNotify)
        _model.SetTeamInfoNotifyCB(@TeamInfoCBNotify)
        _model.SetUpdateTeamMemInfoNotifyCB(@UpdateTeamMemInfoCBNotify)

        return



    NewLeaderCBNotify:(ret_msg)->
        cc.log "NewLeaderCBNotify Respond "
    DissmissTeamNotifyCBNotify:(ret_msg)->
        cc.log "DissmissTeamNotifyCBNotify Respond "
    JoinTeamNotifyCBNotify:(ret_msg)->
        cc.log "JoinTeamNotifyCBNotify Respond "
    KickMemberNotifyCBNotify:(ret_msg)->
        cc.log "KickMemberNotifyCBNotify Respond "
    LeaveTeamNotifyCBNotify:(ret_msg)->
        cc.log "LeaveTeamNotifyCBNotify Respond "
    ApplyTeamNotifyCBNotify:(ret_msg)->
        cc.log "ApplyTeamNotifyCBNotify Respond "
    AgreeApplicantNotifyCBNotify:(ret_msg)->
        cc.log "AgreeApplicantNotifyCBNotify Respond "
    TeamInfoCBNotify:(ret_msg)->
        cc.log "TeamInfoCBNotify Respond "
    UpdateTeamMemInfoCBNotify:(ret_msg)->
        cc.log "UpdateTeamMemInfoCBNotify Respond "


)
TeamController.getInstance = ->
    if this.instance is undefined
        model_ = TeamModel
        model_.Initialize()
        this.instance = new TeamController(model_)
    return this.instance

module.exports = (()->
    if not controller_?
        controller_ = TeamController.getInstance()
    controller_)()
  