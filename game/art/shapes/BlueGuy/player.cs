
singleton TSShapeConstructor(PlayerDts)
{
   baseShape = "./player.dts";
};

function PlayerDts::onLoad(%this)
{
   %this.addSequence("./player_root.dsq", "root", "0", "-1", "1", "0");
   %this.addSequence("./player_back.dsq", "back", "0", "-1", "1", "0");
   %this.addSequence("./player_side.dsq", "side", "0", "-1", "1", "0");
   %this.addSequence("./player_fall.dsq", "fall", "0", "-1", "1", "0");
   %this.addSequence("./player_land.dsq", "land", "0", "-1", "1", "0");
   %this.addSequence("./player_jump.dsq", "jump", "0", "-1", "1", "0");
   %this.addSequence("./player_standjump.dsq", "standjump", "0", "-1", "1", "0");
}
