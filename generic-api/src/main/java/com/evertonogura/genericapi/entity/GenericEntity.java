package com.evertonogura.genericapi.entity;

import java.util.Date;
import java.util.List;
import java.util.Objects;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import com.evertonogura.genericapi.model.GenericChildModel;

@Entity
@Table(name = "ParentTable")
public class GenericEntity {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	
	@Column(name = "Name")
	private String name;
	
	@Column(name = "IsActive")
	private Boolean active;
	
	@Column(name = "ModifyDate")
	private Date date;
	
	@OneToMany(mappedBy = "parent", fetch = FetchType.LAZY)
	private List<GenericChildEntity> items;
	
	public Long getId() {
		return id;
	}

	public void setId(Long id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public Boolean getActive() {
		return active;
	}

	public void setActive(Boolean active) {
		this.active = active;
	}

	public Date getDate() {
		return date;
	}

	public void setDate(Date date) {
		this.date = date;
	}
	
	public List<GenericChildEntity> getItems() {
		return items;
	}

	public void setItems(List<GenericChildEntity> items) {
		this.items = items;
	}

	public GenericEntity() {}

	public GenericEntity(Long id, String name, Boolean active, Date date, List<GenericChildEntity> items) {
		super();
		this.id = id;
		this.name = name;
		this.active = active;
		this.date = date;
		this.items = items;
	}

	@Override
	public int hashCode() {
		return Objects.hash(active, date, id, items, name);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		GenericEntity other = (GenericEntity) obj;
		return Objects.equals(active, other.active) && Objects.equals(date, other.date) && Objects.equals(id, other.id)
				&& Objects.equals(items, other.items) && Objects.equals(name, other.name);
	}

	@Override
	public String toString() {
		return "GenericEntity [id=" + id + ", name=" + name + ", active=" + active + ", date=" + date + ", items="
				+ items + "]";
	}
	
}
