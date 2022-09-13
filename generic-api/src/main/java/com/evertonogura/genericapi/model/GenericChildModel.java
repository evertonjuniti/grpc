package com.evertonogura.genericapi.model;

import java.io.Serializable;
import java.util.Objects;

public class GenericChildModel implements Serializable {
	
	private static final long serialVersionUID = -3274048045374658218L;
	
	private Long itemId;
	
	private String description;
	
	private double value;

	public Long getItemId() {
		return itemId;
	}

	public void setItemId(Long itemId) {
		this.itemId = itemId;
	}

	public String getDescription() {
		return description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	public double getValue() {
		return value;
	}

	public void setValue(double value) {
		this.value = value;
	}

	public GenericChildModel(Long itemId, String description, double value) {
		super();
		this.itemId = itemId;
		this.description = description;
		this.value = value;
	}

	@Override
	public int hashCode() {
		return Objects.hash(description, itemId, value);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		GenericChildModel other = (GenericChildModel) obj;
		return Objects.equals(description, other.description) && Objects.equals(itemId, other.itemId)
				&& Double.doubleToLongBits(value) == Double.doubleToLongBits(other.value);
	}

	@Override
	public String toString() {
		return "GenericStructureModel [itemId=" + itemId + ", description=" + description + ", value=" + value + "]";
	}
	
}
