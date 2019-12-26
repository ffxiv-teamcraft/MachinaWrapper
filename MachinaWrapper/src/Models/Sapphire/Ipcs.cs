namespace Sapphire.Common.Packets
{

    ////////////////////////////////////////////////////////////////////////////////
    /// Lobby Connection IPC Codes
    /**
    * Server IPC Lobby Type Codes.
    */
    enum ServerLobbyIpcType : ushort
    {
        LobbyError = 0x0002,
        LobbyServiceAccountList = 0x000C,
        LobbyCharList = 0x000D,
        LobbyCharCreate = 0x000E,
        LobbyEnterWorld = 0x000F,
        LobbyServerList = 0x0015,
        LobbyRetainerList = 0x0017,

    };

    /**
    * Client IPC Lobby Type Codes.
    */
    enum ClientLobbyIpcType : ushort
    {
        ReqCharList = 0x0003,
        ReqEnterWorld = 0x0004,
        ClientVersionInfo = 0x0005,

        ReqCharDelete = 0x000A,
        ReqCharCreate = 0x000B,
    };

    ////////////////////////////////////////////////////////////////////////////////
    /// Zone Connection IPC Codes
    /**
    * Server IPC Zone Type Codes.
    */
    enum ServerZoneIpcType : ushort
    {

        // static opcode ( the ones that rarely, if ever, change )
        Ping = 0x0065,
        Init = 0x0066,

        ActorFreeSpawn = 0x009B, // updated 5.18
        InitZone = 0x007C, // updated 5.18

        //EffectResult = 0x010B, // updated 5.15
        ActorControl = 0x03BE, // updated 5.18
        ActorControlSelf = 0x00E3, // updated 5.18
        ActorControlTarget = 0x024D, // updated 5.18

        /*!
         * @brief Used when resting
         */
        UpdateHpMpTp = 0x0125, // updated 5.18

        ///////////////////////////////////////////////////

        // ChatBanned = 0x006B,
        PlayTime = 0x00E7, // updated 5.18
        Logout = 0x0142, // updated 5.18
        //CFNotify = 0x0078,
        //CFMemberStatus = 0x0079,
        //CFDutyInfo = 0x007A,
        //CFPlayerInNeed = 0x007F,
        CFNotifyPop = 0x01F8, // updated 5.18
        CFPreferredRole = 0x032A, // updated 5.18

        //SocialRequestError = 0x00AD,

        //CFRegistered = 0x00B8, // updated 4.1
        //SocialRequestResponse = 0x00BB, // updated 4.1
        //CancelAllianceForming = 0x00C6, // updated 4.2

        //LogMessage = 0x00D0,

        Chat = 0x02A3, // updated 5.18

        //WorldVisitList = 0x00FE, // added 4.5

        //SocialList = 0x007A, // updated 5.1

        ExamineSearchInfo = 0x012B, // updated 5.18
        UpdateSearchInfo = 0x01E5, // updated 5.18
        //InitSearchInfo = 0x03A1, // updated 5.1
        //ExamineSearchComment = 0x0102, // updated 4.1

        //ServerNoticeShort = 0x0115, // updated 5.0
        //ServerNotice = 0x0116, // updated 5.0
        //SetOnlineStatus = 0x015E, // updated 5.1

        //CountdownInitiate = 0x0309, // updated 5.11
        CountdownCancel = 0x00D9, // updated 5.18

        //PlayerAddedToBlacklist = 0x033F, // updated 5.1
        //PlayerRemovedFromBlacklist = 0x0385, // updated 5.1
        //BlackList = 0x031F, // updated 5.1

        //LinkshellList = 0x012A, // updated 5.0

        //MailDeleteRequest = 0x012B, // updated 5.0

        // 12D - 137 - constant gap between 4.5x -> 5.0
        //ReqMoogleMailList = 0x0138, // updated 5.0
        //ReqMoogleMailLetter = 0x0139, // updated 5.0
        //MailLetterNotification = 0x013A, // updated 5.0

        MarketTaxRates = 0x025E, // updated 5.18

        MarketBoardItemListingCount = 0x0328, // updated 5.18
        MarketBoardItemListing = 0x015F, // updated 5.18
        MarketBoardItemListingHistory = 0x0113, // updated 5.18
        MarketBoardSearchResult = 0x01EA, // updated 5.18

        //CharaFreeCompanyTag = 0x013B, // updated 4.5
        //FreeCompanyBoardMsg = 0x013C, // updated 4.5
        //FreeCompanyInfo = 0x013D, // updated 4.5
        //ExamineFreeCompanyInfo = 0x013E, // updated 4.5

        //FreeCompanyUpdateShortMessage = 0x0157, // added 5.0

        StatusEffectList = 0x0183, // updated 5.18
        EurekaStatusEffectList = 0x0167, // updated 5.18
        BossStatusEffectList = 0x0312, // added 5.15
        Effect = 0x026B, // updated 5.18
        AoeEffect8 = 0x033E, // updated 5.18
        AoeEffect16 = 0x0305, // updated 5.18
        AoeEffect24 = 0x023F, // updated 5.18
        AoeEffect32 = 0x0352, // updated 5.18
        PersistantEffect = 0x019C, // updated 5.18

        // GCAffiliation = 0x016F, // updated 5.0

        PlayerSpawn = 0x0262, // updated 5.18
        NpcSpawn = 0x0186, // updated 5.18
        NpcSpawn2 = 0x010C, // ( Bigger statuseffectlist? ) updated 5.18
        ActorMove = 0x021B, // updated 5.18

        ActorSetPos = 0x0068, // updated 5.18

        ActorCast = 0x03B1, // updated 5.18
        SomeCustomiseChangePacketProbably = 0x00CD, // updated 5.18
        PartyList = 0x0287, // updated 5.18
        HateRank = 0x0226, // updated 5.18
        HateList = 0x0361, // updated 5.18
        ObjectSpawn = 0x027F, // updated 5.18
        ObjectDespawn = 0x034B, // updated 5.18
        UpdateClassInfo = 0x0362, // updated 5.18
        //SilentSetClassJob = 0x018E, // updated 5.0 - seems to be the case, not sure if it's actually used for anything
        PlayerSetup = 0x0295, // updated 5.18
        PlayerStats = 0x017A, // updated 5.18
        //ActorOwner = 0x0322, // updated 5.11
        PlayerStateFlags = 0x02C6, // updated 5.18
        //PlayerClassInfo = 0x02D4, // updated 5.1

        //ModelEquip = 0x0170, // updated 5.11
        Examine = 0x0366, // updated 5.18
        CharaNameReq = 0x0116, // updated 5.18

        // nb: see #565 on github
        //UpdateRetainerItemSalePrice = 0x019F, // updated 5.0

        //SetLevelSync = 0x1186, // not updated for 4.4, not sure what it is anymore

        ItemInfo = 0x00F2, // updated 5.18
        ContainerInfo = 0x01F2, // updated 5.18
        //InventoryTransactionFinish = 0x01AB, // updated 5.1
        //InventoryTransaction = 0x023E, // updated 5.1
        CurrencyCrystalInfo = 0x02BF, // updated 5.18

        //InventoryActionAck = 0x0084, // updated 5.1
        UpdateInventorySlot = 0x0370, // updated 5.18

        //HuntingLogEntry = 0x01B3, // updated 5.0

        EventPlay = 0x0279, // updated 5.18
        // DirectorPlayScene = 0x01B9, // updated 5.0
        //EventOpenGilShop = 0x01BC, // updated 5.0

        EventStart = 0x0230, // updated 5.18
        EventFinish = 0x0230, // updated 5.18
        EventUnk0 = 0x02F7, // updated 5.18
        EventUnk1 = 0x0100, // updated 5.18
        UseMooch = 0x0233, // updated 5.18

        //EventLinkshell = 0x1169,

        //QuestActiveList = 0x01D2, // updated 5.0
        //QuestUpdate = 0x01D3, // updated 5.0
        QuestCompleteList = 0x0066, // updated 5.18

        QuestFinish = 0x025D, // updated 5.18
        //MSQTrackerComplete = 0x01D6, // updated 5.0
        //MSQTrackerProgress = 0xF1CD, // updated 4.5 ? this actually looks like the two opcodes have been combined, see #474

        //QuestMessage = 0x01DE, // updated 5.0

        //QuestTracker = 0x01E3, // updated 5.0

        Mount = 0x02F0, // updated 5.18

        //DirectorVars = 0x01F5, // updated 5.0
        //DirectorPopUp = 0x0200, // updated 5.0 - display dialogue pop-ups in duties and FATEs, for example, Teraflare's countdown

        //CFAvailableContents = 0xF1FD, // updated 4.2

        // WeatherChange = 0x02FB, // updated 5.11
        //PlayerTitleList = 0x037D, // updated 5.1
        Discovery = 0x0285, // updated 5.18

        //EorzeaTimeOffset = 0x03B8, // updated 5.1

        // EquipDisplayFlags = 0x011D, // updated 5.11

        /// Housing //////////////////////////////////////

        //LandSetInitialize = 0x0234, // updated 5.0
        //LandUpdate = 0x0235, // updated 5.0
        //YardObjectSpawn = 0x0236, // updated 5.0
        //HousingIndoorInitialize = 0x0237, // updated 5.0
        //LandPriceUpdate = 0x0238, // updated 5.0
        //LandInfoSign = 0x0239, // updated 5.0
        //LandRename = 0x023A, // updated 5.0
        //HousingEstateGreeting = 0x023B, // updated 5.0
        //HousingUpdateLandFlagsSlot = 0x023C, // updated 5.0
        //HousingLandFlags = 0x023D, // updated 5.0
        //HousingShowEstateGuestAccess = 0x023E, // updated 5.0

        //HousingObjectInitialize = 0x0240, // updated 5.0
        //HousingInternalObjectSpawn = 0x241, // updated 5.0

        //HousingWardInfo = 0x0243, // updated 5.0
        //HousingObjectMove = 0x0244, // updated 5.0

        //SharedEstateSettingsResponse = 0x0245, // updated 4.5

        //LandUpdateHouseName = 0x0257, // updated 4.5

        //LandSetMap = 0x025B, // updated 4.5

        //////////////////////////////////////////////////

        //DuelChallenge = 0x0277, // 4.2; this is responsible for opening the ui
        //PerformNote = 0x0286, // updated 4.3

        //PrepareZoning = 0x02A4, // updated 5.0
        ActorGauge = 0x016D, // updated 5.18

        // daily quest info -> without them sent,  login will take longer...
        //DailyQuests = 0x02B6, // updated 5.1
        //DailyQuestRepeatFlags = 0x0124, // updated 5.1

        /// Doman Mahjong //////////////////////////////////////
        //MahjongOpenGui = 0x02A4, // only available in mahjong instance
        //MahjongNextRound = 0x02BD, // initial hands(baipai), # of riichi(wat), winds, honba, score and stuff
        //MahjongPlayerAction = 0x02BE, // tsumo(as in drawing a tile) called chi/pon/kan/riichi
        //MahjongEndRoundTsumo = 0x02BF, // called tsumo
        //MahjongEndRoundRon = 0x2C0, // called ron or double ron (waiting for action must be flagged from discard packet to call)
        //MahjongTileDiscard = 0x02C1, // giri (discarding a tile.) chi(1)/pon(2)/kan(4)/ron(8) flags etc..
        //MahjongPlayersInfo = 0x02C2, // actor id, name, rating and stuff..
        // 2C3 and 2C4 are currently unknown
        //MahjongEndRoundDraw = 0x02C5, // self explanatory
        //MahjongEndGame = 0x02C6, // finished oorasu(all-last) round; shows a result screen.
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {

        //PingHandler = 0x0065, // unchanged 5.0
        //InitHandler = 0x03D2, // updated 5.1

        //FinishLoadingHandler = 0x01DC, // updated 5.1

        //CFCommenceHandler = 0x006F,


        //CFRegisterDuty = 0x0071,
        //CFRegisterRoulette = 0x0072,
        //PlayTimeHandler = 0x0276, // updated 5.1
        //LogoutHandler = 0x02D6, // updated 5.1
        //CancelLogout = 0x008F, // updated 5.1

        //CFDutyInfoHandler = 0x0078, // updated 4.2

        //SocialReqSendHandler = 0x00AE, // updated 4.1
        //CreateCrossWorldLS = 0x00AF, // updated 4.3

        ChatHandler = 0x0130, // updated 5.18

        //SocialListHandler = 0x01F6, // updated 5.1
        SetSearchInfoHandler = 0x0320, // updated 5.18
        //ReqSearchInfoHandler = 0x024D, // updated 5.1
        //ReqExamineSearchCommentHandler = 0x00E7, // updated 5.0

        //ReqRemovePlayerFromBlacklist = 0x00F1, // updated 5.0
        //BlackListHandler = 0x0167, // updated 5.1
        //PlayerSearchHandler = 0x00F4, // updated 5.0

        //LinkshellListHandler = 0x00D3, // updated 5.1

        //MarketBoardRequestItemListingInfo = 0x0102, // updated 4.5
        //MarketBoardRequestItemListings = 0x0103, // updated 4.5
        //MarketBoardSearch = 0x0107, // updated 4.5

        //ReqExamineFcInfo = 0x0113, // updated 4.1

        //FcInfoReqHandler = 0x011A, // updated 4.2

        //FreeCompanyUpdateShortMessageHandler = 0x0123, // added 5.0

        //ReqMarketWishList = 0x012C, // updated 4.3

        //ReqJoinNoviceNetwork = 0x0129, // updated 4.2

        //ReqCountdownInitiate = 0x0135, // updated 5.0
        //ReqCountdownCancel = 0x0136, // updated 5.0

        //ZoneLineHandler = 0x02E0, // updated 5.1
        ClientTrigger = 0x03C0, // updated 5.18
        //DiscoveryHandler = 0x0177, // updated 5.1

        //PlaceFieldMarker = 0x013C, // updated 5.0

        //SkillHandler = 0x013D, // updated 5.0
        //GMCommand1 = 0x00A4, // updated 5.1
        //GMCommand2 = 0x013F, // updated 5.0
        //AoESkillHandler = 0x140, // updated 5.0

        UpdatePositionHandler = 0x0355, // updated 5.15

        InventoryModifyHandler = 0x03C5, // updated 5.15
        //InventoryEquipRecommendedItems = 0x0149, // updated 5.0

        //ReqPlaceHousingItem = 0x014B, // updated 5.0
        //BuildPresetHandler = 0x014F, // updated 5.0

        //TalkEventHandler = 0x0151, // updated 5.0
        //EmoteEventHandler = 0x0152, // updated 5.0
        // WithinRangeEventHandler = 0x0165, // updated 5.11
        //OutOfRangeEventHandler = 0x0154, // updated 5.0
        //EnterTeriEventHandler = 0x0155, // updated 5.0
        //ShopEventHandler = 0x0156, // updated 5.0

        //ReturnEventHandler = 0x015A, // updated 5.0?
        //TradeReturnEventHandler = 0x015B, // updated 5.0?

        //LinkshellEventHandler = 0x016B, // updated 4.5
        //LinkshellEventHandler1 = 0x016C, // updated 4.5

        //ReqEquipDisplayFlagsChange = 0x0175, // updated 5.0

        //LandRenameHandler = 0xF177, // updated 5.0
        //HousingUpdateHouseGreeting = 0x0178, // updated 5.0
        //HousingUpdateObjectPosition = 0x0179, // updated 5.0

        //SetSharedEstateSettings = 0x017B, // updated 5.0

        //UpdatePositionInstance = 0x0180, // updated 5.0

        //PerformNoteHandler = 0x029B, // updated 4.3



    };

    ////////////////////////////////////////////////////////////////////////////////
    /// Chat Connection IPC Codes
    /**
    * Server IPC Chat Type Codes.
    */
    enum ServerChatIpcType : ushort
    {
        Tell = 0x0064, // updated for sb
        TellErrNotFound = 0x0066,

        //FreeCompanyEvent = 0x012C, // added 5.0
    };

    /**
    * Client IPC Chat Type Codes.
    */
    enum ClientChatIpcType : ushort
    {
        TellReq = 0x0064,
    };


}