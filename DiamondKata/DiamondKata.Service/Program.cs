using DiamondKata.Service.Implementation;

IDiamondFactory diamondFactory = new DiamondFactory();
var diamond = diamondFactory.CreateDiamond('E');
diamondFactory.DisplayDiamond(diamond);
