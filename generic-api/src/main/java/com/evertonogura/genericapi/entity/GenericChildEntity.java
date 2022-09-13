package com.evertonogura.genericapi.entity;

import java.util.Objects;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name = "ChildTable")
public class GenericChildEntity {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	
	@Column(name = "Description")
	private String description;
	
	@Column(name = "MyValue")
	private double value;
	
	@ManyToOne(fetch = FetchType.EAGER)
	@JoinColumn(name = "Id_Parent", nullable = false)
	private GenericEntity parent;
	
	public Long getId() {
		return id;
	}

	public void setId(Long id) {
		this.id = id;
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
	
	public GenericEntity getParent() {
		return parent;
	}

	public void setParent(GenericEntity parent) {
		this.parent = parent;
	}

	public GenericChildEntity() {}

	public GenericChildEntity(Long id, String description, double value, GenericEntity parent) {
		super();
		this.id = id;
		this.description = description;
		this.value = value;
		this.parent = parent;
	}

	@Override
	public int hashCode() {
		return Objects.hash(description, id, parent, value);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		GenericChildEntity other = (GenericChildEntity) obj;
		return Objects.equals(description, other.description) && Objects.equals(id, other.id)
				&& Objects.equals(parent, other.parent)
				&& Double.doubleToLongBits(value) == Double.doubleToLongBits(other.value);
	}

	@Override
	public String toString() {
		return "GenericChildEntity [id=" + id + ", description=" + description + ", value=" + value + ", parent="
				+ parent + "]";
	}
	
}
