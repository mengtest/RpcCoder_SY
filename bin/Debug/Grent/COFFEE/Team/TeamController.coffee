
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
        _model.SetSummonMemberNotifyNotifyCB(@SummonMemberNotifyCBNotify)
        _model.SetChangeTeamTargetNotifyNotifyCB(@ChangeTeamTargetNotifyCBNotify)
        _model.SetChangeTeamTypeNotifyNotifyCB(@ChangeTeamTypeNotifyCBNotify)
        _model.SetInviteTeamMemberNotifyNotifyCB(@InviteTeamMemberNotifyCBNotify)
        _model.SetApplyListNotifyNotifyCB(@ApplyListNotifyCBNotify)
        _model.SetEnterAutoCombatNotifyCB(@EnterAutoCombatCBNotify)
        _model.SetHangUpAutoCombatNotifyCB(@HangUpAutoCombatCBNotify)
        _model.SetUpdateTeamHpInfoNotifyCB(@UpdateTeamHpInfoCBNotify)
        _model.SetUpdateTeamPosInfoNotifyCB(@UpdateTeamPosInfoCBNotify)
        _model.SetUpdateTeamBuffInfoNotifyCB(@UpdateTeamBuffInfoCBNotify)
        _model.SetUpdateFollowStatusNotifyCB(@UpdateFollowStatusCBNotify)
        _model.SetEnterTeamFollowNotifyCB(@EnterTeamFollowCBNotify)

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
    SummonMemberNotifyCBNotify:(ret_msg)->
        cc.log "SummonMemberNotifyCBNotify Respond "
    ChangeTeamTargetNotifyCBNotify:(ret_msg)->
        cc.log "ChangeTeamTargetNotifyCBNotify Respond "
    ChangeTeamTypeNotifyCBNotify:(ret_msg)->
        cc.log "ChangeTeamTypeNotifyCBNotify Respond "
    InviteTeamMemberNotifyCBNotify:(ret_msg)->
        cc.log "InviteTeamMemberNotifyCBNotify Respond "
    ApplyListNotifyCBNotify:(ret_msg)->
        cc.log "ApplyListNotifyCBNotify Respond "
    EnterAutoCombatCBNotify:(ret_msg)->
        cc.log "EnterAutoCombatCBNotify Respond "
    HangUpAutoCombatCBNotify:(ret_msg)->
        cc.log "HangUpAutoCombatCBNotify Respond "
    UpdateTeamHpInfoCBNotify:(ret_msg)->
        cc.log "UpdateTeamHpInfoCBNotify Respond "
    UpdateTeamPosInfoCBNotify:(ret_msg)->
        cc.log "UpdateTeamPosInfoCBNotify Respond "
    UpdateTeamBuffInfoCBNotify:(ret_msg)->
        cc.log "UpdateTeamBuffInfoCBNotify Respond "
    UpdateFollowStatusCBNotify:(ret_msg)->
        cc.log "UpdateFollowStatusCBNotify Respond "
    EnterTeamFollowCBNotify:(ret_msg)->
        cc.log "EnterTeamFollowCBNotify Respond "


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
  
