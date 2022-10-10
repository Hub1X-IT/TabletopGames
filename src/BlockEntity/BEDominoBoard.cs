using System.Text;
using Vintagestory.API.Common;
using TabletopGames.ModUtils;

namespace TabletopGames
{
    public class BEDominoBoard : BEBoard
    {
        public override string InventoryClassName => "ttgdominoboard";
        public override bool HasWoodType => true;

        public override NewSlotDelegate OnNewSlot() => (f, f2) => new ItemSlotDominoBoard(f2);

        public override void GetBlockInfo(IPlayer forPlayer, StringBuilder dsc)
        {
            base.GetBlockInfo(forPlayer, dsc);
            dsc.AppendWoodText(wood: woodType);
            dsc.AppendLine().AppendSelectedSlotText(Block, forPlayer, inventory, DisplaySelectedSlotId, DisplaySelectedSlotStack);
        }
    }
}