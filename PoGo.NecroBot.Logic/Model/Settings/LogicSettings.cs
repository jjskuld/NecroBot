
#region using directives

using System;
using System.Collections.Generic;
using PoGo.NecroBot.Logic.Interfaces.Configuration;
using POGOProtos.Enums;
using POGOProtos.Inventory.Item;

#endregion

namespace PoGo.NecroBot.Logic.Model.Settings
{
    public class LogicSettings : ILogicSettings
    {
        private readonly GlobalSettings _settings;

        public LogicSettings(GlobalSettings settings)

        {
            _settings = settings;
        }

        public double GenRandom(double maxValue)
        {
            double minValue = maxValue - (maxValue * _settings.GlobalVariancePercentage);
            return (new Random().NextDouble() * (maxValue - minValue)) + minValue;
        }

        public int GenRandom(int maxValue)
        {
            return (int) Math.Ceiling(GenRandom((double)maxValue));
        }

        public float GenRandom(float maxValue)
        {
            return (float) GenRandom((double)maxValue);
        }

        public string ProfilePath => _settings.ProfilePath;
        public string ProfileConfigPath => _settings.ProfileConfigPath;
        public string GeneralConfigPath => _settings.GeneralConfigPath;
        public bool CheckForUpdates => _settings.UpdateConfig.CheckForUpdates;
        public bool AutoUpdate => _settings.UpdateConfig.AutoUpdate;
        public bool TransferConfigAndAuthOnUpdate => _settings.UpdateConfig.TransferConfigAndAuthOnUpdate;
        public double GlobalVariancePercentage => _settings.GlobalVariancePercentage;
        public bool UseWebsocket => _settings.WebsocketsConfig.UseWebsocket;
        public bool CatchPokemon => _settings.PokemonConfig.CatchPokemon;
        public int CatchPokemonLimit => GenRandom(_settings.PokemonConfig.CatchPokemonLimit);
        public int CatchPokemonLimitMinutes => GenRandom(_settings.PokemonConfig.CatchPokemonLimitMinutes);
        public int PokeStopLimit => GenRandom(_settings.PokeStopConfig.PokeStopLimit);
        public int PokeStopLimitMinutes => GenRandom(_settings.PokeStopConfig.PokeStopLimitMinutes);
        public int SnipeCountLimit => GenRandom(_settings.SnipeConfig.SnipeCountLimit);
        public int SnipeRestSeconds => GenRandom(_settings.SnipeConfig.SnipeRestSeconds);
        public bool TransferWeakPokemon => _settings.PokemonConfig.TransferWeakPokemon;
        public bool DisableHumanWalking => _settings.LocationConfig.DisableHumanWalking;
        public int MaxBerriesToUsePerPokemon => GenRandom(_settings.PokemonConfig.MaxBerriesToUsePerPokemon);
        public float KeepMinIvPercentage => GenRandom(_settings.PokemonConfig.KeepMinIvPercentage);
        public string KeepMinOperator => _settings.PokemonConfig.KeepMinOperator;
        public int KeepMinCp => GenRandom(_settings.PokemonConfig.KeepMinCp);
        public int KeepMinLvl => GenRandom(_settings.PokemonConfig.KeepMinLvl);
        public bool UseKeepMinLvl => _settings.PokemonConfig.UseKeepMinLvl;
        public bool AutomaticallyLevelUpPokemon => _settings.PokemonConfig.AutomaticallyLevelUpPokemon;
        public bool OnlyUpgradeFavorites => _settings.PokemonConfig.OnlyUpgradeFavorites;
        public bool UseLevelUpList => _settings.PokemonConfig.UseLevelUpList;
        public int AmountOfTimesToUpgradeLoop => GenRandom(_settings.PokemonConfig.AmountOfTimesToUpgradeLoop);
        public string LevelUpByCPorIv => _settings.PokemonConfig.LevelUpByCPorIv;
        public int GetMinStarDustForLevelUp => GenRandom(_settings.PokemonConfig.GetMinStarDustForLevelUp);
        public bool UseLuckyEggConstantly => _settings.PokemonConfig.UseLuckyEggConstantly;
        public bool UseIncenseConstantly => _settings.PokemonConfig.UseIncenseConstantly;
        public int UseBerriesMinCp => GenRandom(_settings.PokemonConfig.UseBerriesMinCp);
        public float UseBerriesMinIv => GenRandom(_settings.PokemonConfig.UseBerriesMinIv);
        public double UseBerriesBelowCatchProbability => _settings.PokemonConfig.UseBerriesBelowCatchProbability;
        public string UseBerriesOperator => _settings.PokemonConfig.UseBerriesOperator;
        public float UpgradePokemonIvMinimum => GenRandom(_settings.PokemonConfig.UpgradePokemonIvMinimum);
        public float UpgradePokemonCpMinimum => GenRandom(_settings.PokemonConfig.UpgradePokemonCpMinimum);
        public string UpgradePokemonMinimumStatsOperator => _settings.PokemonConfig.UpgradePokemonMinimumStatsOperator;
        public double WalkingSpeedInKilometerPerHour => _settings.LocationConfig.WalkingSpeedInKilometerPerHour;
        public bool UseWalkingSpeedVariant => _settings.LocationConfig.UseWalkingSpeedVariant;
        public double WalkingSpeedVariant => _settings.LocationConfig.WalkingSpeedVariant;
        public bool ShowVariantWalking => _settings.LocationConfig.ShowVariantWalking;
        public bool FastSoftBanBypass => _settings.SoftBanConfig.FastSoftBanBypass;
        public bool EvolveAllPokemonWithEnoughCandy => _settings.PokemonConfig.EvolveAllPokemonWithEnoughCandy;
        public bool KeepPokemonsThatCanEvolve => _settings.PokemonConfig.KeepPokemonsThatCanEvolve;
        public bool TransferDuplicatePokemon => _settings.PokemonConfig.TransferDuplicatePokemon;
        public bool TransferDuplicatePokemonOnCapture => _settings.PokemonConfig.TransferDuplicatePokemonOnCapture;
        public bool UseEggIncubators => _settings.PokemonConfig.UseEggIncubators;
        public int UseEggIncubatorMinKm => GenRandom(_settings.PokemonConfig.UseEggIncubatorMinKm);
        public int UseGreatBallAboveCp => GenRandom(_settings.PokemonConfig.UseGreatBallAboveCp);
        public int UseUltraBallAboveCp => GenRandom(_settings.PokemonConfig.UseUltraBallAboveCp);
        public int UseMasterBallAboveCp => GenRandom(_settings.PokemonConfig.UseMasterBallAboveCp);
        public double UseGreatBallAboveIv => _settings.PokemonConfig.UseGreatBallAboveIv;
        public double UseUltraBallAboveIv => _settings.PokemonConfig.UseUltraBallAboveIv;
        public double UseMasterBallBelowCatchProbability => _settings.PokemonConfig.UseMasterBallBelowCatchProbability;
        public double UseUltraBallBelowCatchProbability => _settings.PokemonConfig.UseUltraBallBelowCatchProbability;
        public double UseGreatBallBelowCatchProbability => _settings.PokemonConfig.UseGreatBallBelowCatchProbability;
        public bool EnableHumanizedThrows => _settings.CustomCatchConfig.EnableHumanizedThrows;
        public bool EnableMissedThrows => _settings.CustomCatchConfig.EnableMissedThrows;
        public int ThrowMissPercentage => _settings.CustomCatchConfig.ThrowMissPercentage;
        public int NiceThrowChance => _settings.CustomCatchConfig.NiceThrowChance;
        public int GreatThrowChance => _settings.CustomCatchConfig.GreatThrowChance;
        public int ExcellentThrowChance => _settings.CustomCatchConfig.ExcellentThrowChance;
        public int CurveThrowChance => _settings.CustomCatchConfig.CurveThrowChance;
        public double ForceGreatThrowOverIv => GenRandom(_settings.CustomCatchConfig.ForceGreatThrowOverIv);
        public double ForceExcellentThrowOverIv => GenRandom(_settings.CustomCatchConfig.ForceExcellentThrowOverIv);
        public int ForceGreatThrowOverCp => GenRandom(_settings.CustomCatchConfig.ForceGreatThrowOverCp);
        public int ForceExcellentThrowOverCp => GenRandom(_settings.CustomCatchConfig.ForceExcellentThrowOverCp);
        public int DelayBetweenPokemonCatch => GenRandom(_settings.PokemonConfig.DelayBetweenPokemonCatch);
        public int DelayBetweenPlayerActions => GenRandom(_settings.PlayerConfig.DelayBetweenPlayerActions);
        public bool UsePokemonToNotCatchFilter => _settings.PokemonConfig.UsePokemonToNotCatchFilter;
        public bool UsePokemonSniperFilterOnly => _settings.PokemonConfig.UsePokemonSniperFilterOnly;
        public int KeepMinDuplicatePokemon => _settings.PokemonConfig.KeepMinDuplicatePokemon;
        public bool PrioritizeIvOverCp => _settings.PokemonConfig.PrioritizeIvOverCp;
        public int MaxTravelDistanceInMeters => GenRandom(_settings.LocationConfig.MaxTravelDistanceInMeters);
        public string GpxFile => _settings.GPXConfig.GpxFile;
        public bool UseGpxPathing => _settings.GPXConfig.UseGpxPathing;
        public bool UseLuckyEggsWhileEvolving => _settings.PokemonConfig.UseLuckyEggsWhileEvolving;
        public int UseLuckyEggsMinPokemonAmount => GenRandom(_settings.PokemonConfig.UseLuckyEggsMinPokemonAmount);
        public bool EvolveAllPokemonAboveIv => _settings.PokemonConfig.EvolveAllPokemonAboveIv;
        public float EvolveAboveIvValue => GenRandom(_settings.PokemonConfig.EvolveAboveIvValue);
        public bool RenamePokemon => _settings.PokemonConfig.RenamePokemon;
        public bool RenameOnlyAboveIv => _settings.PokemonConfig.RenameOnlyAboveIv;
        public float FavoriteMinIvPercentage => GenRandom(_settings.PokemonConfig.FavoriteMinIvPercentage);
        public bool AutoFavoritePokemon => _settings.PokemonConfig.AutoFavoritePokemon;
        public string RenameTemplate => _settings.PokemonConfig.RenameTemplate;
        public int AmountOfPokemonToDisplayOnStart => _settings.ConsoleConfig.AmountOfPokemonToDisplayOnStart;
        public bool DumpPokemonStats => _settings.PokemonConfig.DumpPokemonStats;
        public string TranslationLanguageCode => _settings.ConsoleConfig.TranslationLanguageCode;
        public bool DetailedCountsBeforeRecycling => _settings.ConsoleConfig.DetailedCountsBeforeRecycling;
        public bool VerboseRecycling => _settings.RecycleConfig.VerboseRecycling;
        public double RecycleInventoryAtUsagePercentage => _settings.RecycleConfig.RecycleInventoryAtUsagePercentage;
        public double EvolveKeptPokemonsAtStorageUsagePercentage => GenRandom(_settings.PokemonConfig.EvolveKeptPokemonsAtStorageUsagePercentage);
        public ICollection<KeyValuePair<ItemId, int>> ItemRecycleFilter => _settings.ItemRecycleFilter;
        public ICollection<PokemonId> PokemonsToEvolve => _settings.PokemonsToEvolve;
        public ICollection<PokemonId> PokemonsToLevelUp => _settings.PokemonsToLevelUp;
        public ICollection<PokemonId> PokemonsNotToTransfer => _settings.PokemonsNotToTransfer;
        public ICollection<PokemonId> PokemonsNotToCatch => _settings.PokemonsToIgnore;

        public ICollection<PokemonId> PokemonToUseMasterball => _settings.PokemonToUseMasterball;
        public Dictionary<PokemonId, TransferFilter> PokemonsTransferFilter => _settings.PokemonsTransferFilter;
        public bool StartupWelcomeDelay => _settings.ConsoleConfig.StartupWelcomeDelay;
        public bool UseGoogleWalk => _settings.GoogleWalkConfig.UseGoogleWalk;
        public double DefaultStepLength => GenRandom(_settings.GoogleWalkConfig.DefaultStepLength);
        public bool UseGoogleWalkCache => _settings.GoogleWalkConfig.Cache;
        public string GoogleApiKey => _settings.GoogleWalkConfig.GoogleAPIKey;
        public string GoogleHeuristic => _settings.GoogleWalkConfig.GoogleHeuristic;

        public bool UseYoursWalk => _settings.YoursWalkConfig.UseYoursWalk;
        public string YoursWalkHeuristic => _settings.YoursWalkConfig.YoursWalkHeuristic;

        public bool SnipeAtPokestops => _settings.SnipeConfig.SnipeAtPokestops;

        public bool UseTelegramAPI => _settings.TelegramConfig.UseTelegramAPI;
        public string TelegramAPIKey => _settings.TelegramConfig.TelegramAPIKey;
        public string TelegramPassword => _settings.TelegramConfig.TelegramPassword;
        public int MinPokeballsToSnipe => GenRandom(_settings.SnipeConfig.MinPokeballsToSnipe);
        public int MinPokeballsWhileSnipe => GenRandom(_settings.SnipeConfig.MinPokeballsWhileSnipe);
        public int MaxPokeballsPerPokemon => GenRandom(_settings.PokemonConfig.MaxPokeballsPerPokemon);
        public bool RandomlyPauseAtStops => _settings.LocationConfig.RandomlyPauseAtStops;
        public SnipeSettings PokemonToSnipe => _settings.PokemonToSnipe;
        public string SnipeLocationServer => _settings.SnipeConfig.SnipeLocationServer;
        public int SnipeLocationServerPort => _settings.SnipeConfig.SnipeLocationServerPort;
        public bool GetSniperInfoFromPokezz => _settings.SnipeConfig.GetSniperInfoFromPokezz;
        public bool GetOnlyVerifiedSniperInfoFromPokezz => _settings.SnipeConfig.GetOnlyVerifiedSniperInfoFromPokezz;
        public bool GetSniperInfoFromPokeSnipers => _settings.SnipeConfig.GetSniperInfoFromPokeSnipers;
        public bool GetSniperInfoFromPokeWatchers => _settings.SnipeConfig.GetSniperInfoFromPokeWatchers;
        public bool GetSniperInfoFromSkiplagged => _settings.SnipeConfig.GetSniperInfoFromSkiplagged;
        public bool UseSnipeLocationServer => _settings.SnipeConfig.UseSnipeLocationServer;
        public bool UseTransferIvForSnipe => _settings.SnipeConfig.UseTransferIvForSnipe;
        public bool SnipeIgnoreUnknownIv => _settings.SnipeConfig.SnipeIgnoreUnknownIv;
        public int MinDelayBetweenSnipes => GenRandom(_settings.SnipeConfig.MinDelayBetweenSnipes);
        public double SnipingScanOffset => _settings.SnipeConfig.SnipingScanOffset;
        public bool SnipePokemonNotInPokedex => _settings.SnipeConfig.SnipePokemonNotInPokedex;
        public bool RandomizeRecycle => _settings.RecycleConfig.RandomizeRecycle;
        public int RandomRecycleValue => _settings.RecycleConfig.RandomRecycleValue;
        public bool DelayBetweenRecycleActions => _settings.RecycleConfig.DelayBetweenRecycleActions;
        public int TotalAmountOfPokeballsToKeep => GenRandom(_settings.RecycleConfig.TotalAmountOfPokeballsToKeep);
        public int TotalAmountOfPotionsToKeep => GenRandom(_settings.RecycleConfig.TotalAmountOfPotionsToKeep);
        public int TotalAmountOfRevivesToKeep => GenRandom(_settings.RecycleConfig.TotalAmountOfRevivesToKeep);
        public int TotalAmountOfBerriesToKeep => GenRandom(_settings.RecycleConfig.TotalAmountOfBerriesToKeep);
        public bool UseSnipeLimit => _settings.SnipeConfig.UseSnipeLimit;
        public bool UsePokeStopLimit => _settings.PokeStopConfig.UsePokeStopLimit;
        public bool UseCatchLimit => _settings.PokemonConfig.UseCatchLimit;
        public int ResumeTrack => _settings.LocationConfig.ResumeTrack;
        public int ResumeTrackSeg => _settings.LocationConfig.ResumeTrackSeg;
        public int ResumeTrackPt => _settings.LocationConfig.ResumeTrackPt;

        public bool HumanWalkingSnipeDisplayList => _settings.HumanWalkSnipeConfig.DisplayPokemonList;
        public double HumanWalkingSnipeMaxDistance => GenRandom(_settings.HumanWalkSnipeConfig.MaxDistance);
        public double HumanWalkingSnipeMaxEstimateTime => GenRandom(_settings.HumanWalkSnipeConfig.MaxEstimateTime);
        public bool HumanWalkingSnipeTryCatchEmAll => _settings.HumanWalkSnipeConfig.TryCatchEmAll;
        public bool HumanWalkingSnipeCatchPokemonWhileWalking => _settings.HumanWalkSnipeConfig.CatchPokemonWhileWalking;
        public double HumanWalkingSnipeSnipingScanOffset => _settings.HumanWalkSnipeConfig.SnipingScanOffset;
        public bool HumanWalkingSnipeSpinWhileWalking => _settings.HumanWalkSnipeConfig.SpinWhileWalking;
        public bool HumanWalkingSnipeAlwaysWalkBack => _settings.HumanWalkSnipeConfig.AlwaysWalkback;
        public int HumanWalkingSnipeCatchEmAllMinBalls => GenRandom(_settings.HumanWalkSnipeConfig.CatchEmAllMinBalls);
        public bool EnableHumanWalkingSnipe => _settings.HumanWalkSnipeConfig.Enable;

        public Dictionary<PokemonId, HumanWalkSnipeFilter> HumanWalkSnipeFilters => _settings.HumanWalkSnipeFilters;

        public double HumanWalkingSnipeWalkbackDistanceLimit => GenRandom(_settings.HumanWalkSnipeConfig.WalkbackDistanceLimit);
        public bool HumanWalkingSnipeIncludeDefaultLocation => _settings.HumanWalkSnipeConfig.IncludeDefaultLocation;
    }
}
