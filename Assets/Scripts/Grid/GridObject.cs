using System.Collections.Generic;

public class GridObject {

    private GridSystemHex<GridObject> gridSystem;
    private GridPosition gridPosition;
    private List<Unit> unitList;
    private IInteractable interactable;

    public GridObject(GridSystemHex<GridObject> gridSystem, GridPosition gridPosition) {
        this.gridSystem = gridSystem;
        this.gridPosition = gridPosition;
        unitList = new List<Unit>();
    }

    public override string ToString() {
        string unitString = "";
        foreach (Unit unit in unitList) {
            unitString += unit + "\n";
        }
        // NOTE retirado a sobrescrita do ToString
        // return gridPosition.ToString() + "\n" + unitString;
        return "";
    }

    public void AddUnit(Unit unit) {
        unitList.Add(unit);
    }

    public void RemoveUnit(Unit unit) {
        unitList.Remove(unit);
    }

    public List<Unit> GetUnitList() {
        return unitList;
    }

    public bool HasAnyUnit() {
        return unitList.Count > 0;
    }

    public Unit GetUnit() {
        if (HasAnyUnit()) {
            return unitList[0];
        } else {
            return null;
        }
    }

    public IInteractable GetInteractable() {
        return interactable;
    }

    public void SetInteractable(IInteractable interactable) {
        this.interactable = interactable;
    }
}
