
BaseController = require("./../../base/BaseController.coffee")
DungeonModel = require("./DungeonModel.coffee")



DungeonController = cc.coffee.BaseControllerExtend.extend(

    ctor:(_model)->
        @_super(this, _model)
        _model.SetSettlementNotifyCB(@SettlementCBNotify)

        return



    SettlementCBNotify:(ret_msg)->
        cc.log "SettlementCBNotify Respond "


)
DungeonController.getInstance = ->
    if this.instance is undefined
        model_ = DungeonModel
        model_.Initialize()
        this.instance = new DungeonController(model_)
    return this.instance

module.exports = (()->
    if not controller_?
        controller_ = DungeonController.getInstance()
    controller_)()
  
